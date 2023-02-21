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
            
            panel1.Controls.Add(SignUp);
        }
    }
}