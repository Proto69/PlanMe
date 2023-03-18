namespace PlanMe.User_Controls
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        //Activates after clicking on LogInButton
        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads the username from the UsernameBox and the password from the PasswordBox and checks if user with these params exist
                LoginView.ReadInfo(UsernameBox.Text, PasswordBox.Text);

                //If the user does exist opens the MainScreen controler otherwise throws an exception
                PageControl.MainScreen();

                //Loads the data for the current user
                MainModels.user.FillEventsAndTasks();

            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }

        //Activates after clicking on SignUpLinkedLabel
        private void SignUpLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens SignUp control
            PageControl.SignUp();
        }
    }
}
