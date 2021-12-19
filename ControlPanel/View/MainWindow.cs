using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPanel.Core;
using Grpc.Core;
using Grpc.Net.Client;
using TaskManager;
using Action = TaskManager.Action;

namespace ControlPanel.View
{
    public partial class MainWindow : Form
    {
        private Thread _grpcRunner;
        private readonly TaskManagersSearcher _searcher;

        private readonly ShowServerInfoDialog _serverInfoDialog;

        private GrpcChannel? _currentConnection;
        private ServerInfo? _serverInfo;

        public MainWindow()
        {
            InitializeComponent();
            _searcher = new TaskManagersSearcher();
            _searcher.NewTaskManagerFound += OnNewTaskManagerFound;
            _serverInfoDialog = new ShowServerInfoDialog();
            _serverInfo = null;
            _searcher.Start();
        }


        private async Task HandleConnection()
        {
            var client = new ConnectionManager.ConnectionManagerClient(_currentConnection);
            using (var call = client.Run())
            {
                var responseReaderTask = Task.Run(async () =>
                {
                    await foreach (var message in call.ResponseStream.ReadAllAsync())
                    {
                        var note = call.ResponseStream.Current;
                        Debug.WriteLine("Received " + note);
                    }
                });

                var random = new Random();
                int i = 0;
                while (i < 30)
                {
                    Thread.Sleep(2000);
                    var data = "Rand: " + random.NextDouble();
                    await call.RequestStream.WriteAsync(new RequestMgs {Message = data, Action = Action.Get});
                    i++;
                }

                await call.RequestStream.CompleteAsync();
                await responseReaderTask;
            }
        }

        private void OnNewTaskManagerFound(string taskManagerName)
        {
            try
            {
                ComputersList.Invoke((MethodInvoker) delegate { ComputersList.Items.Add(taskManagerName); });
            }
            catch (InvalidAsynchronousStateException e)
            {
                Debug.WriteLine(e);
            }
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_grpcRunner.Join();
            _searcher.Stop();
        }

        private void ShowInfoComputerBtn_Click(object sender, EventArgs e)
        {
            if (_serverInfo == null)
            {
                // TODO notify
                return;
            }

            _serverInfoDialog.ServerInfo = _serverInfo;
            _serverInfoDialog.ShowDialog();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (_serverInfo == null)
            {
                // TODO notify
                return;
            }

            _currentConnection = GrpcChannel.ForAddress($"https://localhost:{_serverInfo.Port}");
            _grpcRunner = new Thread(() =>
            {
                try
                {
                    var task = Task.Run(async () => await HandleConnection());
                    task.Wait();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine($"Exception caught: {exception}");
                }
            });
            _grpcRunner.Start();
        }

        private void ComputersList_SelectedIndexChanged(object sender, EventArgs e) =>
            _serverInfo = _searcher.TaskManagers.Find(
                tm => tm.ServiceInstanceName == ComputersList.SelectedItem.ToString());
    }
}