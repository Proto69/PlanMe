using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            if (name != "" && name != null && dateTimePicker1.Checked)
            {
                List<Event> events = allPlans.Where(x => x.Name == name && x.Date.Date == date.Date).ToList();
                dataGridView1.DataSource = events;
            }
            else if (name != "" && name != null)
            {
                List<Event> events = allPlans.Where(x => x.Name == name).ToList();
                dataGridView1.DataSource = events;
            }
            else if (dateTimePicker1.Checked)
            {
                List<Event> events = allPlans.Where(x => x.Date.Date == date.Date).ToList();
                dataGridView1.DataSource = events;

            }
            else
                ErrorView.ShowError("You should type something!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            EventData.Delete(currentEvent);
            allPlans.Remove(currentEvent);
            //dataGridView1.Rows.RemoveAt(rowIndex);
        }

        //THIS IS NOT WORKING
        private Event GetEventFromGrid(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string oldName = allPlans[rowIndex].Name;
            DateOnly date = DateOnly.ParseExact(allPlans[rowIndex].Date.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            TimeOnly time = TimeOnly.ParseExact(allPlans[rowIndex].Date.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            string info = allPlans[rowIndex].Info;


            Event currentEvemt = new Event(oldName, dateTime, time.ToString(), info);

            return currentEvemt;
        }

        private void DeleteEvent(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string oldName = allPlans[rowIndex].Name;
            DateOnly date = DateOnly.ParseExact(allPlans[rowIndex].Date.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            TimeOnly time = TimeOnly.ParseExact(allPlans[rowIndex].Date.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            string info = allPlans[rowIndex].Info;
            if (cell.Value == null)
            {
                Event currentEvemt = new Event(oldName, dateTime, time.ToString(), info);
                EventData.Delete(currentEvemt);
                allPlans.Remove(currentEvemt);


                //THIS STUPID SHIT DOES NOT WORK
                //dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentEvent = GetEventFromGrid(e);
        }
    }
}
