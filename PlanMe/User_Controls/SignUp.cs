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
            }
            catch (Exception k)
            {
                ErrorView.ShowError(k.Message);
            }
        }
    }
}
