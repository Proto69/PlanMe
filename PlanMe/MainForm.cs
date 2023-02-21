using PlanMe.User_Controls;

namespace PlanMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Example for displaying user controls
            SignUp sign = new();
            panel1.Controls.Add(sign);
        }
    }
}