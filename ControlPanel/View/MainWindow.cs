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

namespace ControlPanel.View
{
    public partial class MainWindow : Form
    {
        private readonly Thread _grpcRunner;
        private readonly TaskManagersSearcher _searcher;

        private readonly ShowServerInfoDialog _serverInfoDialog;

        public MainWindow()
        {
            InitializeComponent();
            _searcher = new TaskManagersSearcher();
            _searcher.NewTaskManagerFound += OnNewTaskManagerFound;
            _serverInfoDialog = new ShowServerInfoDialog();

            _grpcRunner = new Thread(() =>
            {
                try
                {
                    var task = Task.Run(async () => await Run());
                    task.Wait();
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Exception caught: {e}");
                }
            });
            _searcher.Start();
        }


        async Task Run()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ConnectionManager.ConnectionManagerClient(channel);
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
                    await call.RequestStream.WriteAsync(new RequestMgs {Message = data});
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
            var serverInfo = _searcher.TaskManagers.Find(
                tm => tm.ServiceInstanceName == ComputersList.SelectedItem.ToString());
            if (serverInfo == null)
            {
                // TODO notify
                return;
            }

            _serverInfoDialog.ServerInfo = serverInfo;
            _serverInfoDialog.ShowDialog();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
        }

        private void ComputersList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}