namespace PlanMe.User_Controls
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpView.ReadInfo(NameBox.Text, PasswordBox.Text, RepeatPasswordBox.Text);

                PageControl.WelcomePage();
            }
            catch (Exception k)
            {
                MessageView.ShowError(k.Message);
            }

        }

        private void LogInLinkedLabel_LinkClicked(object sender, EventArgs e)
        {
            PageControl.LogIn();
        }
    }
}
