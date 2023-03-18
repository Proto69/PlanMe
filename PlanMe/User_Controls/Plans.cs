namespace PlanMe.User_Controls
{
    public partial class Plans : UserControl
    {
        public Plans()
        {
            InitializeComponent();
        }


        private void addPlan_Click(object sender, EventArgs e)
        {
            PageControl.AddAPlan();
        }

        private void seePlan_Click(object sender, EventArgs e)
        {
            PageControl.SeeAPlan();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            PageControl.Calendar();
        }

        private void back_Click(object sender, EventArgs e)
        {
            PageControl.MainScreen();
        }
    }
}
