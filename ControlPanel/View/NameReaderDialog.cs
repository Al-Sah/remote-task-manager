using System;
using System.Windows.Forms;

namespace ControlPanel.View
{
    public partial class NameReaderDialog : Form
    {
        public string ProcessName { get; private set; }
        public NameReaderDialog() => InitializeComponent();

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ProcessName = NameTextBox.Text;
            if (ProcessName == string.Empty)
            {
                Notifier.ErrorMessageBox("Invalid process name");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}