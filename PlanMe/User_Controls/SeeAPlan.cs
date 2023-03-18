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
            dateTimePicker1.Checked = false;
        }


        private void showButton_Click_Event(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            if (name != "" && name != null && dateTimePicker1.Checked)
            {
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower()) && x.Date.Date == date.Date).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else if (name != "" && name != null)
            {
                List<Event> events = allPlans.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else if (dateTimePicker1.Checked)
            {
                List<Event> events = allPlans.Where(x => x.Date.Date == date.Date).ToList();
                FillTable(events);
                currentPlans = events;
            }
            else
                ErrorView.ShowError("You should type something!");
        }

        private void onlyNameSearch_Click_Event(object sender, EventArgs e)
        {
            dateTimePicker1.Checked = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string oldName = currentPlans[rowIndex].Name;
            DateTime oldDate = currentPlans[rowIndex].Date;
            string oldTime = currentPlans[rowIndex].Time;
            string oldInfo = currentPlans[rowIndex].Info;

            var oldEvent = new Event(oldName, oldDate, oldTime, oldInfo);

            if (cell.Value.ToString() == "")
            {
                EventData.Delete(oldEvent);
                MainModels.user.Events = EventData.GetAll();
                dataGridView1.Rows.RemoveAt(rowIndex);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            dataGridView1.DataSource = table;
        }

        private void back_Click(object sender, EventArgs e)
        {
            PageControl.Plans();
        }
    }
}
