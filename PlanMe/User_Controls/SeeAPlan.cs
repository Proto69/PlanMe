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
            dateTimePicker1.Checked = false;
        }


        private void showButton_Click_Event(object sender, EventArgs e)
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

        private void onlyNameSearch_Click_Event(object sender, EventArgs e)
        {
            dateTimePicker1.Checked = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
