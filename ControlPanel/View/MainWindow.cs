using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ControlPanel.Core;
using Grpc.Net.Client;
using Newtonsoft.Json;
using TaskManager;
using static System.String;


namespace ControlPanel.View
{
    public partial class MainWindow : Form
    {
        private readonly TaskManagersSearcher _searcher;
        private readonly ConnectionManager _connectionManager;
        private readonly ShowServerInfoDialog _serverInfoDialog;


        private ServerInfo? _serverInfo;

        public MainWindow()
        {
            InitializeComponent();
            _connectionManager = new ConnectionManager();
            _connectionManager.NewDataReceived += ProcessesGridViewSafeUpdate;

            _searcher = new TaskManagersSearcher();
            _searcher.NewTaskManagerFound += OnNewTaskManagerFound;
            _serverInfoDialog = new ShowServerInfoDialog();
            _serverInfo = null;
            _searcher.Start();
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
            _connectionManager.ShutDownConnection();
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

            if (_connectionManager.IsRunning())
            {
                // TODO notify
                return;
            }

            _connectionManager.SetupConnection(GrpcChannel.ForAddress($"https://localhost:{_serverInfo.Port}"));
            _connectionManager.RunClient();
        }

        private void ComputersList_SelectedIndexChanged(object sender, EventArgs e) =>
            _serverInfo = _searcher.TaskManagers.Find(
                tm => tm.ServiceInstanceName == ComputersList.SelectedItem.ToString());


        private void ProcessesGridViewSafeUpdate(string processes)
        {
            try
            {
                ProcessesGridView.Invoke((MethodInvoker) delegate
                {
                    var processesList = JsonConvert.DeserializeObject<List<ProcessInfoBase>>(processes);
                    if (processesList != null)
                    {
                        GridViewManager.Update(processesList, ProcessesGridView);
                    }
                });
            }
            catch (InvalidAsynchronousStateException e)
            {
                Debug.WriteLine(e);
            }
        }


        private static class GridViewManager
        {
            private static void ResetDataGrid(List<ProcessInfoBase> processes, DataGridView gridView)
            {
                gridView.Rows.Clear();
                SortProcesses(processes, gridView);
                gridView.Rows.AddRange(processes.Select(process => new DataGridViewRow
                {
                    Cells =
                    {
                        new DataGridViewTextBoxCell {Value = process.Name},
                        new DataGridViewTextBoxCell {Value = process.Pid},
                        new DataGridViewTextBoxCell {Value = process.Priority},
                        new DataGridViewTextBoxCell {Value = process.ProcessorAffinity},
                        new DataGridViewTextBoxCell {Value = process.Memory},
                        new DataGridViewTextBoxCell {Value = process.Path}
                    }
                }).ToArray());
            }

            public static void Update(List<ProcessInfoBase> processes, DataGridView gridView)
            {
                if (processes.Count != gridView.Rows.Count)
                {
                    if (Math.Abs(processes.Count - gridView.Rows.Count) > 10)
                    {
                        ResetDataGrid(processes, gridView);
                        return;
                    }

                    UpdateRows(processes.Count, gridView);
                }

                SortProcesses(processes, gridView);

                for (var index = 0; index < gridView.Rows.Count; index++)
                {
                    var process = processes[index];
                    var row = gridView.Rows[index];
                    UpdateUnit(row.Cells[0], process.Name);
                    UpdateUnit(row.Cells[1], process.Pid);
                    UpdateUnit(row.Cells[2], process.Priority);
                    UpdateUnit(row.Cells[3], process.ProcessorAffinity);
                    UpdateUnit(row.Cells[4], process.Memory);
                    UpdateUnit(row.Cells[5], process.Path);
                }
            }

            private static void SortProcesses(List<ProcessInfoBase> processes, DataGridView gridView)
            {
                switch (gridView.Columns.IndexOf(gridView.SortedColumn))
                {
                    case 0:
                        processes.Sort((x, y) => CompareOrdinal(x.Name, y.Name));
                        break;
                    case 1:
                        processes.Sort((x, y) => x.Pid.CompareTo(y.Pid));
                        break;
                    case 2:
                        processes.Sort((x, y) => CompareOrdinal(x.Priority, y.Priority));
                        break;
                    case 3:
                        processes.Sort((x, y) => x.ProcessorAffinity.CompareTo(y.ProcessorAffinity));
                        break;
                    case 4:
                        processes.Sort((x, y) => x.Memory.CompareTo(y.Memory));
                        break;
                    case 5:
                        processes.Sort((x, y) => CompareOrdinal(x.Path, y.Path));
                        break;
                }

                if (gridView.SortOrder == SortOrder.Descending)
                {
                    processes.Reverse();
                }
            }

            private static void UpdateRows(int processes, DataGridView gridView)
            {
                var res = processes - gridView.Rows.Count;
                if (res <= 0)
                {
                    for (var i = 0; i < (res * -1); i++)
                    {
                        gridView.Rows.RemoveAt(gridView.Rows.Count - 1);
                    }
                }
                else
                {
                    try
                    {
                        gridView.Rows.Add(res);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                    }
                }
            }

            private static void UpdateUnit(DataGridViewCell cell, object value)
            {
                if (cell.Value != value)
                {
                    cell.Value = value;
                }
            }
        }
    }
}