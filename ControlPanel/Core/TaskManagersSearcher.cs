using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using Makaretu.Dns;

namespace ControlPanel.Core
{
    public class TaskManagersSearcher
    {
        private readonly EventWaitHandle _event;
        private readonly Thread _executor;
        private readonly Thread _updater;
        private bool _started;

        private const int SecondsTimeout = 5;

        private readonly MulticastService _mdns;
        private readonly ServiceDiscovery _serviceDiscovery;

        public List<ServerInfo> TaskManagers { get; }

        public delegate void NewItem(string message);

        public event NewItem? NewTaskManagerFound;

        public TaskManagersSearcher()
        {
            _event = new ManualResetEvent(true);
            _executor = new Thread(_start);
            _mdns = new MulticastService {IgnoreDuplicateMessages = true};
            _serviceDiscovery = new ServiceDiscovery(_mdns);

            TaskManagers = new List<ServerInfo>();

            _updater = new Thread(() =>
            {
                var domainName = new DomainName("alx-grpc-tm");
                const int timeout = SecondsTimeout * 1000;
                while (_started)
                {
                    _serviceDiscovery.QueryServiceInstances(domainName);
                    ValidateData();
                    Thread.Sleep(timeout);
                }
            });
        }


        public void Start()
        {
            if (_started)
            {
                return;
            }

            _executor.Start();
        }

        public void Stop()
        {
            _started = false;
            _event.Set();
            _executor.Join();
            _updater.Join();
        }

        private void _start()
        {
            _started = true;
            _event.Reset();

            _serviceDiscovery.ServiceInstanceDiscovered += (_, e) =>
            {
                var serverInfo = TaskManagers.Find(tm => tm.ServiceInstanceName == e.ServiceInstanceName.ToString());
                if (serverInfo != null)
                {
                    serverInfo.LastUpdate = DateTime.Now;
                }
                else
                {
                    var newTaskManager = new ServerInfo
                    {
                        ServiceInstanceName = e.ServiceInstanceName.ToString()
                    };
                    newTaskManager.ServiceLabels.AddRange(e.ServiceInstanceName.Labels);
                    TaskManagers.Add(newTaskManager);
                    NewTaskManagerFound?.Invoke(e.ServiceInstanceName.ToString());

                    _mdns.SendQuery(e.ServiceInstanceName, type: DnsType.SRV);
                    _mdns.SendQuery(e.ServiceInstanceName, type: DnsType.A);
                }
            };

            _mdns.AnswerReceived += (_, e) =>
            {
                // This is an answer to a service instance details
                var servers = e.Message.Answers.OfType<SRVRecord>();
                SetTaskManagersPort(servers);
                // This is an answer to host addresses
                var addresses = e.Message.Answers.OfType<AddressRecord>();
                SetTaskManagersAddress(addresses);
            };

            _updater.Start();
            _mdns.Start();
            _event.WaitOne();
        }


        private void SetTaskManagersAddress(IEnumerable<AddressRecord> addresses)
        {
            foreach (var address in addresses)
            {
                var serverInfo = TaskManagers.Find(tm => tm.ServiceInstanceName == address.Name.ToString());
                if (serverInfo == null)
                {
                    Debug.WriteLine($"AnswerReceived from undefined service: {address.Name}");
                    continue;
                }

                serverInfo.Address = address.Address;
            }
        }

        private void SetTaskManagersPort(IEnumerable<SRVRecord> servers)
        {
            foreach (var server in servers)
            {
                var serverInfo = TaskManagers.Find(tm => tm.ServiceInstanceName == server.Name);
                if (serverInfo == null)
                {
                    Debug.WriteLine($"AnswerReceived from undefined service: {server.Name}");
                    continue;
                }

                serverInfo.Port = server.Port;
            }
        }

        private void ValidateData()
        {
            foreach (var taskManager in TaskManagers)
            {
                var toDeprecated = DateTime.Now - taskManager.LastUpdate > TimeSpan.FromSeconds(SecondsTimeout * 2);

                if (!Equals(taskManager.Address, IPAddress.None) && taskManager.Port != 0 && !toDeprecated)
                {
                    taskManager.CurrentState = ServerInfo.DataState.Valid;
                    continue;
                }

                if (!toDeprecated)
                {
                    continue;
                }

                if (Equals(taskManager.Address, IPAddress.None) || taskManager.Port == 0)
                {
                    taskManager.CurrentState = ServerInfo.DataState.Failed;
                }
                else
                {
                    taskManager.CurrentState = ServerInfo.DataState.Deprecated;
                }
            }
        }
    }
}