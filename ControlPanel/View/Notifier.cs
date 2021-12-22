using System.Windows.Forms;

namespace ControlPanel.View
{
    public static class Notifier
    {
        private const string Error = "Error";
        private const string Info = "Notificatin";

        public static void ErrorMessageBox(string error)
        {
            MessageBox.Show(error, Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InformationMessageBox(string info)
        {
            MessageBox.Show(info, Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}