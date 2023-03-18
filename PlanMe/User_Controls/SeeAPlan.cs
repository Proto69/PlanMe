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
                FillTable(events);
                currentPlans = events;
            }
            else if (name != "" && name != null)
            {
                //Displays all events that match the name
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else if (DatePlanPicker.Checked)
            {
                //Displays all events that match the date
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

        private void onlyNameSearch_Click_Event(object sender, EventArgs e)
        {
            DatePlanPicker.Checked = false;
        }

        private void PlansDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = PlansDataGridView.Rows[rowIndex];

            DataGridViewCell cell = PlansDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string oldName = currentPlans[rowIndex].Name;
            DateTime oldDate = currentPlans[rowIndex].Date;
            string oldTime = currentPlans[rowIndex].Time;
            string oldInfo = currentPlans[rowIndex].Info;

            var oldEvent = new Event(oldName, oldDate, oldTime, oldInfo);

            if (cell.Value.ToString() == "")
            {
                EventData.Delete(oldEvent);
                MainModels.user.Events = EventData.GetAll();
                PlansDataGridView.Rows.RemoveAt(rowIndex);
                allPlans = MainModels.user.Events;
            }
            else
            {

                string newName = row.Cells[0].Value.ToString();
                DateTime newDate = DateTime.Parse(row.Cells[1].Value.ToString());
                string newTime = row.Cells[2].Value.ToString();
                string newInfo = row.Cells[3].Value.ToString();

                var newEvent = new Event(newName, newDate, newTime, newInfo);

                EventData.Update(oldEvent, newEvent);

                for (int i = 0; i < allPlans.Count; i++)
                {
                    if (currentPlans[i].Name == oldName && currentPlans[i].Date == oldDate && currentPlans[i].Time == oldTime && currentPlans[i].Info == oldInfo)
                    {
                        currentPlans[i].Name = newName;
                        currentPlans[i].Date = newDate;
                        currentPlans[i].Time = newTime;
                        currentPlans[i].Info = newInfo;
                        break;
                    }
                }

            }
        }

        public void FillTable(List<Event> list)
        {
            table = new();

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Info", typeof(string));

            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].Name, list[i].Date, list[i].Time, list[i].Info);
            }

            PlansDataGridView.DataSource = table;
        }
    }
}
