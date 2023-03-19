namespace PlanMe.User_Controls
{
    public partial class SeeAPlan : UserControl
    {
        DataTable table = new();
        List<Event> allPlans = MainModels.user.Events;
        List<Event> currentPlans;

        public SeeAPlan()
        {
            InitializeComponent();

            //Clears date picker
            DatePlanPicker.Checked = false;
        }

        // Activates after clicking on the BackButton
        private void BackButton_Click(object sender, EventArgs e)
        {
            //Opens Plans control
            PageControl.Plans();
        }

        // Activates after clicking on the ClearDateButton
        private void ClearDateButton_Click(object sender, EventArgs e)
        {
            // Clears date picker
            DatePlanPicker.Checked = false;
        }

        // Activates after clicking on the ShowButton
        private void ShowButton_Click(object sender, EventArgs e)
        {
            // Gets the name from the NameBox
            string name = NameBox.Text;

            // Picks the date from the DatePlanPicker
            DateTime date = DatePlanPicker.Value;

            // Checks if the name is valid and if the DatePlanPicker is checked otherwise throws an exception (if both are not valid)
            if (name != "" && name != null && DatePlanPicker.Checked)
            {
                // Displays all events that match both the name and the date
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower()) && x.Date.Date == date.Date).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else if (name != "" && name != null)
            {
                // Displays all events that match the name
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else if (DatePlanPicker.Checked)
            {
                // Displays all events that match the date
                List<Event> events = allPlans.Where(x => x.Date.Date == date.Date).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else
            {
                FillTable(allPlans);
                currentPlans = allPlans;
            }
        }

        private void PlansDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Retrieve the row and cell from the event arguments
                var row = PlansDataGridView.Rows[e.RowIndex];
                var cell = row.Cells[e.ColumnIndex];

                // Retrieve the old plan object from the currentPlans list
                var oldPlan = currentPlans[e.RowIndex];

                // Check if the cell value is empty
                if (cell.Value?.ToString() == "")
                {
                    // If the cell value is empty, delete the old plan from the database and update the UI
                    EventData.Delete(new Event(oldPlan.Name, oldPlan.Date, oldPlan.Time, oldPlan.Info));
                    MainModels.user.Events = EventData.GetAll();
                    PlansDataGridView.Rows.RemoveAt(e.RowIndex);
                    allPlans = MainModels.user.Events;
                }
                else
                {
                    // If the cell value is not empty, retrieve the new plan information from the DataGridViewRow
                    var newName = row.Cells[0].Value?.ToString();
                    var newDateString = row.Cells[1].Value?.ToString();
                    var newTime = row.Cells[2].Value?.ToString();
                    var newInfo = row.Cells[3].Value?.ToString();

                    // Try to parse the new date string to a DateTime object
                    DateTime newDate;
                    if (!DateTime.TryParse(newDateString, out newDate))
                    {
                        // Handle invalid date format here
                        MessageView.ShowError("Invalid date format!");
                    }

                    // Create a new Event object with the new plan information
                    var newPlan = new Event(newName, newDate, newTime, newInfo);

                    // Update the old plan in the database with the new plan information
                    EventData.Update(new Event(oldPlan.Name, oldPlan.Date, oldPlan.Time, oldPlan.Info), newPlan);

                    // Find the index of the old plan in the allPlans list and update it with the new plan
                    var index = allPlans.IndexOf(oldPlan);
                    if (index != -1)
                    {
                        currentPlans[index] = newPlan;
                    }
                }
            }
            // Catches when there is a duplicate in primary keys in database
            catch (MySqlException)
            {
                MessageView.ShowError("There is already a plan with these paramaters!");
            }
            // Catches any other error
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }


        }

        // Fills the table with values
        public void FillTable(List<Event> list)
        {
            // Create a new DataTable object
            var table = new DataTable();

            // Add columns to the DataTable for the plan information
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Info", typeof(string));

            // Loop through the list of plans and add a new row to the DataTable for each plan
            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].Name, list[i].Date, list[i].Time, list[i].Info);
            }

            // Set the DataTable as the data source for the PlansDataGridView control
            PlansDataGridView.DataSource = table;

        }
    }
}
