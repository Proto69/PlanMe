namespace PlanMe.User_Controls
{
    public partial class AddAPlan : UserControl
    {
        public AddAPlan()
        {
            InitializeComponent();
        }

        //Activates after the button is clicked
        private void AddPlanButton_Click(object sender, EventArgs e)
        {
            //Tries to create plan and throws exception if it is not possible
            try
            {

                DateTime date = new DateTime();
                try
                {
                    //Tries to parse the date from the DateBox to DateTime and throws exception if it is not possible
                    date = DateTime.Parse(DateBox.Text);
                }
                catch (Exception ex)
                {
                    ErrorView.ShowError(ex.Message);
                }

                string time = timeBox.Text;
                if (time == null || time == "")
                    time = "00:00:00";

                //Creates current event
                Event currEvent = new Event(NameBox.Text, date, time, InfoBox.Text);

                //Uploads the event
                EventData.Upload(currEvent);
                MainModels.user.Events.Add(currEvent);
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
