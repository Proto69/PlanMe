using PlanMe.Data;
using PlanMe.Models;
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
    public partial class ExistingList : UserControl
    {
        public ExistingList()
        {
            InitializeComponent();
            /*List<UserTask> tasks = TaskData.GetAll(MainModels.user.Username);
            foreach (var task in tasks)
            {
                CheckBox box = new CheckBox() { Text = task.Text, Checked = task.IsDone };
                checkedListBox1.Items.Add(box);
                checkedListBox1.DisplayMember = "Text";
            }*/
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainModels.form.ShowAddATask();
        }
    }
}
