namespace PlanMe.User_Controls
{
    public partial class Plans : UserControl
    {
        public Plans()
        {
            InitializeComponent();
        }
        //Activates after clicking on the AddPlanButton
        private void AddPlanButton_Click(object sender, EventArgs e)
        {
            //Opens AddAPlan control
            PageControl.AddAPlan();
        }

        //Activates after clicking on the BackButton
        private void BackButton_Click(object sender, EventArgs e)
        {
            //Opens MainScreen control
            PageControl.MainScreen();
        }

        //Activates after clicking on the ShowAllPlansButton
        private void ShowAllPlansButton_Click(object sender, EventArgs e)
        {
            //Opens Calendar control
            PageControl.Calendar();
        }

        //Activates after clicking on the SeePlanButton
        private void SeePlanButton_Click(object sender, EventArgs e)
        {
            //Opens SeeAPlan control
            PageControl.SeeAPlan();
        }
    }
}
