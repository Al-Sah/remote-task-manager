using System.Windows.Forms;
using Grpc.Net.Client;
using TaskManager;

namespace ControlPanel
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ConnectionManager.ConnectionManagerClient(channel);
        }
    }
}