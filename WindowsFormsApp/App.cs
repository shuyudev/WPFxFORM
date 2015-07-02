using System.Windows.Forms;
using WpfControl.ViewModel;

namespace WindowsFormsApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            _viewModel = new TaskEditorViewModel("FormApp");
            taskEditor1.DataContext = _viewModel;
        }

        private readonly TaskEditorViewModel _viewModel;

        private void button1_Click(object sender, System.EventArgs e)
        {
            button1.Text  = _viewModel.Count.ToString();
        }
    }
}
