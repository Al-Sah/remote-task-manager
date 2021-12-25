using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlPanel.View
{
    public partial class SetupAffinityDialog : Form
    {
        public long ProcessorsCount { get; set; }
        public int Mask { get; private set; }

        public SetupAffinityDialog() => InitializeComponent();

        private void SetupAffinityDialog_Load(object sender, EventArgs e)
        {
            ProcessorsList.Items.Clear();
            ProcessorsList.SetItemChecked(ProcessorsList.Items.Add("< Use All >"), true);
            for (var i = 1; i < ProcessorsCount + 1; i++)
            {
                ProcessorsList.SetItemChecked(ProcessorsList.Items.Add("CPU" + i), true);
            }
        }

        private void SetupMask()
        {
            if (ProcessorsList.CheckedIndices.Contains(0))
            {
                Mask = (int) ((1U << (int) ProcessorsCount) - 1U);
            }

            Mask = (int) ProcessorsList.CheckedIndices
                .Cast<int>()
                .Aggregate(0L, (current, item) => current | (uint) (1 << (item - 1)));
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            SetupMask();
            Close();
        }
    }
}