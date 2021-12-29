using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TaskManager;

namespace ControlPanel.View
{
    public partial class ProcessModificationDialog : Form
    {
        public int Cores { get; set; }
        public List<Modification> ProcessModification { get; }

        private Modification? _current;

        private readonly SetupAffinityDialog _setupAffinityDialog;

        public ProcessModificationDialog()
        {
            InitializeComponent();
            ProcessModification = new List<Modification>();

            _setupAffinityDialog = new SetupAffinityDialog();
            _setupAffinityDialog.FormClosing += (_, _) => AffinityTextBox.Text = _setupAffinityDialog.Mask.ToString();
        }

        private void ModifyProcessDialog_Load(object sender, EventArgs e)
        {
            RequestsList.Items.Clear();
            foreach (var modification in ProcessModification)
            {
                RequestsList.Items.Add(modification.Id);
            }

            AffinityTextBox.Enabled = ConfigAffinityBtn.Enabled = Cores != 0;
        }

        private void RequestsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequestsList.SelectedItem == null) return;
            SaveCurrentValues();

            if (int.TryParse(RequestsList.SelectedItem.ToString(), out var res))
            {
                _current = ProcessModification.Find(r => r.Id == res);
                NameTextBox.Text = _current.Name;
                AffinityTextBox.Text = _current.Affinity.ToString();
                PrioritiesList.SelectedItem = _current.Priority;
            }
            else
            {
                Notifier.ErrorMessageBox("Undefined item");
            }
        }

        private void SaveCurrentValues()
        {
            if (_current == null)
            {
                return;
            }

            _current.Name = NameTextBox.Text;
            _current.Affinity = AffinityTextBox.Text == string.Empty ? 0 : int.Parse(AffinityTextBox.Text);
            _current.Priority = PrioritiesList.SelectedItem.ToString();
        }

        private void ConfigAffinityBtn_Click(object sender, EventArgs e) => _setupAffinityDialog.ShowDialog();

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            SaveCurrentValues();
            var errorsBuilder = new StringBuilder();
            foreach (var startup in ProcessModification)
            {
                var res = ValidateInput(startup);
                if (res != string.Empty)
                {
                    errorsBuilder.Append($"Request {startup.Id} errors: ")
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


        private string ValidateInput(Modification info)
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
                return errorsBuilder.ToString();
            }

            if (info.Affinity < 1 || info.Affinity > (int) ((1U << Cores) - 1U))
            {
                errorsBuilder.Append("Field 'Affinity' contains invalid value");
            }

            return errorsBuilder.ToString();
        }
    }
}