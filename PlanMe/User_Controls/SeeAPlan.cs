namespace PlanMe.User_Controls
{
    public partial class SeeAPlan : UserControl
    {
        DataTable table = new();
        List<Event> allPlans = MainModels.user.Events;
        Event currentEvent = new Event();



        public SeeAPlan()
        {
            InitializeComponent();

            //Clears date picker
            DatePlanPicker.Checked = false;
        }

        //Activates after clicking on the BackButton
        private void BackButton_Click(object sender, EventArgs e)
        {
            //Opens Plans control
            PageControl.Plans();
        }

        //Activates after clicking on the ClearDateButton
        private void ClearDateButton_Click(object sender, EventArgs e)
        {
            //Clears date picker
            DatePlanPicker.Checked = false;
        }

        //Activates after clicking on the ShowButton
        private void ShowButton_Click(object sender, EventArgs e)
        {
            //Gets the name from the NameBox
            string name = NameBox.Text;
            
            //Picks the date from the DatePlanPicker
            DateTime date = DatePlanPicker.Value;

            //Checks if the name is valid and if the DatePlanPicker is checked otherwise throws an exception (if both are not valid)
            if (name != "" && name != null && DatePlanPicker.Checked)
            {
                //Displays all events that match both the name and the date
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower()) && x.Date.Date == date.Date).ToList();
                PlansDataGridView.DataSource = events;
            }
            else if (name != "" && name != null)
            {
                //Displays all events that match the name
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                PlansDataGridView.DataSource = events;
            }
            else if (DatePlanPicker.Checked)
            {
                //Displays all events that match the date
                List<Event> events = allPlans.Where(x => x.Date.Date == date.Date).ToList();
                PlansDataGridView.DataSource = events;

            }
            else
                ErrorView.ShowError("You should type something!");
        }
    }
}
