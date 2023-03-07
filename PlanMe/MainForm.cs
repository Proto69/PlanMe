using Google.Protobuf.Collections;
using PlanMe.Controlls;
using PlanMe.Models;
using PlanMe.User_Controls;
using PlanMe.Views;

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
            MainModels.form = this;
            PageControl.ShowSignUp();
        }

    }
}