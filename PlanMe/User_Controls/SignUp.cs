namespace PlanMe.User_Controls
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //Activates after clicking on the SignUpButton
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //Trys to create user otherwise throws an exception
            try
            {
                //Reads
                //      the name from the NameBox
                //      the password from the PasswordBox
                //      the RepeatPassword from the RepeatPasswordBox
                //and creates user with these parameters
                SignUpView.ReadInfo(NameBox.Text, PasswordBox.Text, RepeatPasswordBox.Text);

                //Opens WelcomePage control
                PageControl.WelcomePage();
            }
            catch (Exception k)
            {
                ErrorView.ShowError(k.Message);
            }
        }

        //Activates after clicking on the LogInLinkedLabel
        private void LogInLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens LogIn control
            PageControl.LogIn();
        }
    }
}

