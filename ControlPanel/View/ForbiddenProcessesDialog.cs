using System;
using System.Windows.Forms;
using ControlPanel.Core;

namespace ControlPanel.View
{
    public partial class ForbiddenProcessesDialog : Form
    {
        private readonly IForbiddenProcessesManager _connectionManager;
        private readonly NameReaderDialog _nameReaderDialog;

        public ForbiddenProcessesDialog(IForbiddenProcessesManager connectionManager)
        {
            _connectionManager = connectionManager;
            InitializeComponent();
            _nameReaderDialog = new NameReaderDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_nameReaderDialog.ShowDialog() == DialogResult.OK)
                {
                    Notifier.InformationMessageBox(
                        _connectionManager.ManageForbidden(
                            _nameReaderDialog.ProcessName,
                            IForbiddenProcessesManager.ForbidAction.Add));
                    UpdateListBtn_Click(new object(), EventArgs.Empty);
                }
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void UpdateListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                NamesListBox.Items.Clear();
                // ReSharper disable once CoVariantArrayConversion
                NamesListBox.Items.AddRange(_connectionManager.GetForbidden().ToArray());
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Notifier.InformationMessageBox(_connectionManager.ManageForbidden(
                    NamesListBox.SelectedItem.ToString() ?? string.Empty,
                    IForbiddenProcessesManager.ForbidAction.Delete));
                UpdateListBtn_Click(new object(), EventArgs.Empty);
            }
            catch (Exception exception)
            {
                Notifier.ErrorMessageBox(exception.Message);
            }
        }

        private void ForbiddenProcessesDialog_Load(object sender, EventArgs e) =>
            UpdateListBtn_Click(new object(), EventArgs.Empty);
    }
}