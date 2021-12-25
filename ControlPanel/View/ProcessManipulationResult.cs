using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TaskManager;

namespace ControlPanel.View
{
    public partial class ProcessManipulationResult : Form
    {
        public List<ProcessStatus> Results { get; set; }
        public string Action { get; set; }

        public ProcessManipulationResult() => InitializeComponent();

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ResultsDataGridView.Rows.Clear();
            Close();
        }

        private void ProcessManipulationResult_LoadDialog(object sender, EventArgs e)
        {
            ActionLabel.Text = Action;
            ResultsDataGridView.Rows.AddRange(Results.Select(process => new DataGridViewRow
            {
                Cells =
                {
                    new DataGridViewTextBoxCell {Value = process.Id},
                    new DataGridViewTextBoxCell {Value = process.Status}
                }
            }).ToArray());
        }
    }
}