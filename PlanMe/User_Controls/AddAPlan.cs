using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PlanMe.User_Controls
{
    public partial class AddAPlan : UserControl
    {
        public AddAPlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = new DateTime();
                try
                {
                    date = DateTime.Parse(DateBox.Text);
                }
                catch(Exception ex) 
                {
                    ErrorView.ShowError(ex.Message);
                }
                string time = date.TimeOfDay.ToString();
                Event currEvent = new Event(NameBox.Text, date, time, InfoBox.Text);
                EventData.Upload(currEvent, MainModels.user.Username);
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
