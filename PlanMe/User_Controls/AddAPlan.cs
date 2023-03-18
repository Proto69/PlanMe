namespace PlanMe.User_Controls
{
    public partial class AddAPlan : UserControl
    {
        public AddAPlan()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime date = new DateTime();
                try
                {
                    date = DateTime.Parse(DateBox.Text);
                }
                catch (Exception ex)
                {
                    ErrorView.ShowError(ex.Message);
                }

                string time = date.TimeOfDay.ToString();

                Event currEvent = new Event(NameBox.Text, date, time, InfoBox.Text);
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
