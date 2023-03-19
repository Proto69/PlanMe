namespace PlanMe.User_Controls
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUpLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageControl.SignUp();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoginView.ReadInfo(UsernameBox.Text, PasswordBox.Text);

                PageControl.MainScreen();

                MainModels.user.FillEventsAndTasks();

            }
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }
        }
    }
}
