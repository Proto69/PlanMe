using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMe.User_Controls
{
    public partial class SeeAPlan : UserControl
    {
        public SeeAPlan()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            if (name != "" && name != null && dateTimePicker1.Checked)
            {
                List<Event> events = MainModels.user.Events.Where(x => x.Name == name && x.Date.Date == date.Date).ToList();
                dataGridView1.DataSource = events;
            }
            else if (name != "" && name != null)
            {
                List<Event> events = MainModels.user.Events.Where(x => x.Name == name).ToList();
                dataGridView1.DataSource = events;
            }
            else if (dateTimePicker1.Checked)
            {
                List<Event> events = MainModels.user.Events.Where(x => x.Date.Date == date.Date).ToList();
                dataGridView1.DataSource = events;

            }
            else
                ErrorView.ShowError("You should type something!");
        }
    }
}
