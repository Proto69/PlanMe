using PlanMe.User_Controls;

namespace PlanMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SignUp sign = new();
            panel1.Controls.Add(sign);
        }
    }
}