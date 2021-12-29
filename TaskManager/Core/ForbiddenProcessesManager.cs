using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TaskManager.Core
{
    public class ForbiddenProcessesManager
    {
        private static ForbiddenProcessesManager _instance;
        private List<string> ForbiddenList { get; }
        private readonly Thread _worker;
        private readonly object _locker = new object();
        private bool _run;

        private ForbiddenProcessesManager()
        {
            ForbiddenList = new List<string>();
            _worker = new Thread(() =>
            {
                while (_run)
                {
                    lock (_locker)
                    {
                        foreach (var process in ForbiddenList.SelectMany(Process.GetProcessesByName))
                        {
                            process.Kill();
                        }
                    }

                    Thread.Sleep(10);
                }
            });
            _worker.Start();
            _run = true;
        }


        public static ForbiddenProcessesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ForbiddenProcessesManager();
            }

            return _instance;
        }

        public string AddItem(string name)
        {
            lock (_locker)
            {
                if (ForbiddenList.Exists(s => s == name))
                {
                    return $"Item '{name}' exists";
                }

                ForbiddenList.Add(name);
            }

            return "Ok";
        }

        public string RemoveItem(string name)
        {
            lock (_locker)
            {
                return ForbiddenList.Remove(name) ? "Ok" : $"Failed to find '{name}'";
            }
        }

        public void Stop()
        {
            _run = false;
            _worker.Join();
        }
    }
}