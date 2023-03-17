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

        private void logInLinkLabel_Click(object sender, EventArgs e)
        {
            PageControl.LogIn();
        }
    }
}
