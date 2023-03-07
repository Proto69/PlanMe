using PlanMe.Controlls;
using PlanMe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMe.User_Controls
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageControl.SignUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginView.ReadInfo(usernameBox.Text, passwordBox.Text);

                PageControl.MainScreen();
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
