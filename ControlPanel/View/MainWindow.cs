using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ControlPanel.Core;
using TaskManager;
using static System.String;


namespace ControlPanel.View
{
    public partial class MainWindow : Form
    {
        private readonly TaskManagersSearcher _searcher;
        private readonly ConnectionManager _connectionManager;
        private readonly ShowServerInfoDialog _serverInfoDialog;

        private readonly ProcessManipulationResult _processManipulationResult;
        private readonly StartNewProcessDialog _startNewProcessDialog;
        private readonly ProcessModificationDialog _processModificationDialog;
        private readonly ForbiddenProcessesDialog _forbiddenProcessesDialog;

        private ServerInfo? _serverInfo;

        public MainWindow()
        {
            InitializeComponent();
            _connectionManager = new ConnectionManager();
            _connectionManager.NewDataReceived += ProcessesGridViewSafeUpdate;
            _connectionManager.ExceptionCaught += Notifier.ErrorMessageBox;

            _processManipulationResult = new ProcessManipulationResult();
            _startNewProcessDialog = new StartNewProcessDialog {Owner = this};

            _processModificationDialog = new ProcessModificationDialog();

            _forbiddenProcessesDialog = new ForbiddenProcessesDialog(_connectionManager) {Owner = this};

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


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connectionManager.NewDataReceived -= ProcessesGridViewSafeUpdate;
            _connectionManager.ExceptionCaught -= Notifier.ErrorMessageBox;
            _searcher.NewTaskManagerFound -= OnNewTaskManagerFound;
            _connectionManager.ShutDownConnection();
            _searcher.Stop();
        }

        private void ShowInfoComputerBtn_Click(object sender, EventArgs e)
        {
            if (_serverInfo == null)
            {
                Notifier.ErrorMessageBox("Server information was not set");
                return;
            }

            _serverInfoDialog.ServerInfo = _serverInfo;
            _serverInfoDialog.ShowDialog();
        }

        private bool ValidateServerInformation()
        {
            if (_serverInfo == null)
            {
                Notifier.ErrorMessageBox("Server information was not set");
                return false;
            }

            if (_serverInfo.CurrentState is ServerInfo.DataState.Failed or ServerInfo.DataState.Deprecated)
            {
                Notifier.ErrorMessageBox("Incorrect Server information");
                return false;
            }

            return true;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateServerInformation())
            {
                return;
            }

            if (!_connectionManager.SetupNewConnection(_serverInfo!))
            {
                Notifier.ErrorMessageBox("Connection setup fail");
                return;
            }

            _connectionManager.StartMainCall();
            Notifier.InformationMessageBox("Connected !!!");
        }

        private void ComputersList_SelectedIndexChanged(object sender, EventArgs e) =>
            _serverInfo = _searcher.TaskManagers.Find(
                tm => tm.ServiceInstanceName == ComputersList.SelectedItem.ToString());


        private void ProcessesGridViewSafeUpdate(List<ProcessInformation> processes)
        {
            try
            {
                ProcessesGridView.Invoke((MethodInvoker) delegate
                {
                    GridViewManager.Update(processes, ProcessesGridView);
                });
            }
            catch (InvalidAsynchronousStateException e)
            {
                Debug.WriteLine(e);
            }
        }


        private void ShowRemoteCallResult(List<ProcessStatus> result, string action)
        {
            if (result.Count == 0)
            {
                return;
            }

            _processManipulationResult.Action = action;
            _processManipulationResult.Results = result;
            _processManipulationResult.ShowDialog();
        }

        private void StartProcessBtn_Click(object sender, EventArgs e)
        {
            _startNewProcessDialog.Cores = 0;
            if (_startNewProcessDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                ShowRemoteCallResult(_connectionManager.StartNewProcesses(_startNewProcessDialog.Request), "Start");
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void DeleteProcessBtn_Click(object sender, EventArgs e)
        {
            var selectedRowCount = ProcessesGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount <= 0) return;

            var processesIds = (from DataGridViewRow selectedRow in ProcessesGridView.SelectedRows
                select (int) selectedRow.Cells[1].Value).ToList();

            try
            {
                ShowRemoteCallResult(_connectionManager.DeleteProcesses(processesIds), "Deletion");
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void ModifyProcessBtn_Click(object sender, EventArgs e)
        {
            if (ProcessesGridView.SelectedRows.Count <= 0) return;

            _processModificationDialog.ProcessModification.Clear();
            foreach (DataGridViewRow selectedRow in ProcessesGridView.SelectedRows)
            {
                _processModificationDialog.ProcessModification.Add(
                    new Modification
                    {
                        Id = (int) selectedRow.Cells["PID"].Value,
                        Affinity = (int) selectedRow.Cells["Affinity"].Value,
                        Priority = selectedRow.Cells["Priority"].Value.ToString(),
                        Name = selectedRow.Cells["Process"].Value.ToString()
                    }
                );
            }

            if (_processModificationDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                ShowRemoteCallResult(_connectionManager.ModifyProcesses(_processModificationDialog.ProcessModification),
                    "Modification");
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void ManageForbiddenBtn_Click(object sender, EventArgs e) => _forbiddenProcessesDialog.ShowDialog();

        private static class GridViewManager
        {
            private static void ResetDataGrid(List<ProcessInformation> processes, DataGridView gridView)
            {
                gridView.Rows.Clear();
                SortProcesses(processes, gridView);
                gridView.Rows.AddRange(processes.Select(process => new DataGridViewRow
                {
                    Cells =
                    {
                        new DataGridViewTextBoxCell {Value = process.Name},
                        new DataGridViewTextBoxCell {Value = process.Id},
                        new DataGridViewTextBoxCell {Value = process.Priority},
                        new DataGridViewTextBoxCell {Value = process.Affinity},
                        new DataGridViewTextBoxCell {Value = process.Memory},
                        new DataGridViewTextBoxCell {Value = process.Path}
                    }
                }).ToArray());
            }

            public static void Update(List<ProcessInformation> processes, DataGridView gridView)
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
                    UpdateUnit(row.Cells[1], process.Id);
                    UpdateUnit(row.Cells[2], process.Priority);
                    UpdateUnit(row.Cells[3], process.Affinity);
                    UpdateUnit(row.Cells[4], process.Memory);
                    UpdateUnit(row.Cells[5], process.Path);
                }
            }

            private static void SortProcesses(List<ProcessInformation> processes, DataGridView gridView)
            {
                switch (gridView.Columns.IndexOf(gridView.SortedColumn))
                {
                    case 0:
                        processes.Sort((x, y) => CompareOrdinal(x.Name, y.Name));
                        break;
                    case 1:
                        processes.Sort((x, y) => x.Id.CompareTo(y.Id));
                        break;
                    case 2:
                        processes.Sort((x, y) => CompareOrdinal(x.Priority, y.Priority));
                        break;
                    case 3:
                        processes.Sort((x, y) => x.Affinity.CompareTo(y.Affinity));
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