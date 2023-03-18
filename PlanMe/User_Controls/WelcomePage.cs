namespace PlanMe.User_Controls
{
    public partial class WelcomePage : UserControl
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Opens the MainScreen controler
            PageControl.MainScreen();
        }
    }
}
