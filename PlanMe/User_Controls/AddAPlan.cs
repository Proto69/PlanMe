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
            // Tries to create plan and throws exception if it is not possible
            try
            {

                // Tries to parse the date from the DateBox to DateTime and throws exception if it is not possible
                DateTime date = DateTime.ParseExact(DateBox.Text, "dd/MM/yyyy", null);


                string time = timeBox.Text;
                if (time == null || time == "")
                    time = "00:00:00";

                // Creates current event
                Event currEvent = new Event(NameBox.Text, date, time, InfoBox.Text);

                // Uploads the event
                EventData.Upload(currEvent);
                MainModels.user.Events.Add(currEvent);
                MessageView.ShowSuccess("You successfully added a plan!");
            }
            // Catches when there is a duplicate in primary keys in database
            catch (MySqlException)
            {
                MessageView.ShowError("You already have a plan with these parameters!");
            }
            // Catches any other error
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }
        }
    }
}
