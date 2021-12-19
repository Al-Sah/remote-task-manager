using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using ControlPanel.Core;

namespace ControlPanel.View
{
    public partial class ShowServerInfoDialog : Form
    {
        public ServerInfo ServerInfo { get; set; }

        public ShowServerInfoDialog() => InitializeComponent();

        private void ShowServerInfoDialog_Load(object sender, EventArgs e)
        {
            ServiceInstanceNameValueLabel.Text = ServerInfo.ServiceInstanceName;
            CurrentStateValueLabel.Text = ServerInfo.CurrentState.ToString();
            LastUpdateValueLabel.Text = ServerInfo.LastUpdate.ToString(CultureInfo.CurrentCulture);
            AddressValueLabel.Text = ServerInfo.Address.ToString();
            PortValueLabel.Text = ServerInfo.Port.ToString();
            ServerInfo.DataUpdated += UpdateLabels;
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();


        private void UpdateLabels()
        {
            SafeUpdateLabel(CurrentStateValueLabel, ServerInfo.CurrentState.ToString());
            SafeUpdateLabel(LastUpdateValueLabel, ServerInfo.LastUpdate.ToString(CultureInfo.CurrentCulture));
            SafeUpdateLabel(AddressValueLabel, ServerInfo.Address.ToString());
            SafeUpdateLabel(PortValueLabel, ServerInfo.Port.ToString());
        }

        private static void SafeUpdateLabel(Control label, string value)
        {
            try
            {
                label.Invoke((MethodInvoker) delegate { label.Text = value; });
            }
            catch (InvalidAsynchronousStateException e)
            {
                Debug.WriteLine(e);
            }
        }

        private void ShowServerInfoDialog_FormClosing(object sender, FormClosingEventArgs e) =>
            ServerInfo.DataUpdated -= UpdateLabels;
    }
}