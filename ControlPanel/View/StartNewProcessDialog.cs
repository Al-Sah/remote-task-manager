using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager;

namespace ControlPanel.View
{
    public partial class StartNewProcessDialog : Form
    {
        private readonly SetupAffinityDialog _setupAffinityDialog;
        private int _requestId;
        private StartupInformation? _current;

        public List<StartupInformation> Request { get; }
        public int Cores { get; set; }

        public StartNewProcessDialog()
        {
            InitializeComponent();
            Request = new List<StartupInformation>();
            _setupAffinityDialog = new SetupAffinityDialog();
            _setupAffinityDialog.FormClosing += (_, _) => AffinityTextBox.Text = _setupAffinityDialog.Mask.ToString();
        }

        private void SetupProcessBtn_Click(object sender, EventArgs e)
        {
            SaveCurrentValues();
            var errorsBuilder = new StringBuilder();
            foreach (var startup in Request)
            {
                var res = ValidateInput(startup);
                if (res != string.Empty)
                {
                    errorsBuilder.Append($"Request {startup.RequestId} errors: ")
                        .Append(res)
                        .Append('\n');
                }
            }

            if (errorsBuilder.ToString() != string.Empty)
            {
                Notifier.ErrorMessageBox(errorsBuilder.ToString());
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveCurrentValues()
        {
            if (_current == null)
            {
                return;
            }

            _current.Name = FileTextBox.Text;
            _current.Affinity = AffinityTextBox.Text == string.Empty ? 0 : int.Parse(AffinityTextBox.Text);
            _current.Priority = PrioritiesList.SelectedItem.ToString();
            _current.Arguments = ArgumentsTextBox.Text;
        }

        private string ValidateInput(StartupInformation info)
        {
            var errorsBuilder = new StringBuilder();
            if (info.Name == string.Empty)
            {
                errorsBuilder.Append("Field 'Name' cannot be empty");
            }

            if (info.Priority == string.Empty)
            {
                errorsBuilder.Append("Field 'Priority' cannot be empty");
            }

            if (Cores == 0)
            {
                info.Affinity = 0;
            }
            else if (info.Affinity < 1 || info.Affinity > (int) ((1U << Cores) - 1U))
            {
                errorsBuilder.Append("Field 'Affinity' contains invalid value");
            }

            return errorsBuilder.ToString();
        }

        private void StartProcessDialog_Load(object sender, EventArgs e)
        {
            _requestId = 0;
            Request.Clear();
            RequestsList.Items.Clear();


            AffinityTextBox.Enabled = ManageAffinityBtn.Enabled = Cores != 0;
            AffinityTextBox.Text = Cores == 0 ? "0" : ((int) ((1U << Cores) - 1U)).ToString();

            CreateNewRequest();
            RequestsList.SelectedIndex = 0;
        }

        private void ManageAffinityBtn_Click(object sender, EventArgs e) => _setupAffinityDialog.ShowDialog();


        private void RequestsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequestsList.SelectedItem is null) return;
            SaveCurrentValues();

            if (int.TryParse(RequestsList.SelectedItem.ToString(), out var res))
            {
                _current = Request.Find(r => r.RequestId == res);
                FileTextBox.Text = _current.Name;
                AffinityTextBox.Text = _current.Affinity.ToString();
                PrioritiesList.SelectedItem = _current.Priority;
                ArgumentsTextBox.Text = _current.Arguments;
            }
            else
            {
                Notifier.ErrorMessageBox("Undefined item");
            }
        }

        private void CreateNewRequest()
        {
            _requestId++;
            var newRequest = new StartupInformation
            {
                RequestId = _requestId,
                Priority = "Normal"
            };
            Request.Add(newRequest);
            RequestsList.Items.Add(_requestId);
        }

        private void AddBtn_Click(object sender, EventArgs e) => CreateNewRequest();

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var items = RequestsList.SelectedItems.Cast<int>().ToList();
            foreach (var request in items)
            {
                var startupInformation = Request.Find(information =>
                    information.RequestId == int.Parse(request.ToString() ?? "-1"));
                if (startupInformation == null)
                {
                    continue;
                }

                Request.Remove(startupInformation);
                RequestsList.Items.Remove(request);
            }

            if (RequestsList.Items.Count == 0)
            {
                _requestId = 0;
                CreateNewRequest();
            }
        }
    }
}