using System;
using PlanMe.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanMe.Models;
using PlanMe.Controls;

namespace PlanMe.User_Controls
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpView.ReadInfo(nameTextBox.Text, passwordTextBox.Text, repeatPasswordTextBox.Text);

                PageControl.WelcomePage();
            }
            catch (Exception k)
            {
                ErrorView.ShowError(k.Message);
            }

        }

        private void logInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageControl.LogIn();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
