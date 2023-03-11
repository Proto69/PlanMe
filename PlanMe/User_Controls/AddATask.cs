using PlanMe.Models;
using PlanMe.Views;
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
    public partial class AddATask : UserControl
    {
        public AddATask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddATaskView.CreateTask(text.Text);
                MainModels.lists.DisplayAllTasks();
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
