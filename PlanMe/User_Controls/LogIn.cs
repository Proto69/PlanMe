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

                MainModels.user.FillEventsAndTasks();

            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
