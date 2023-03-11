using PlanMe.Controlls;
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
    public partial class TaskScreen : UserControl
    {
        public TaskScreen()
        {
            InitializeComponent();
            DisplayAllTasks();
        }

        private void ClickCheckBox(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            DataControl.UpdateTask(box.Text, MainModels.tasks.Name, box.Checked);
        }

        public void DisplayAllTasks()
        {
            checkedListBox1.Items.Clear();
            List<UserTask> tasks = TaskData.GetAll(MainModels.tasks.Name, MainModels.user.Username);
            foreach (var task in tasks)
            {
                CheckBox box = new CheckBox() { Text = task.Text, Checked = task.IsDone };
                if (box.Checked)
                    box.Enabled = false;
                box.CheckedChanged += ClickCheckBox;

                checkedListBox1.Items.Add(box);
                checkedListBox1.DisplayMember = "Text";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PopUpForm form = new PopUpForm();
            form.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PageControl.MainScreen();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Идеята ми е да се отваря нов прозорец в който да
            //се покажат всички задачи като check box и да се маркират 
            //и после да натиснеш Delete и да се изтрият маркираните, като
            //има и бутон Delete All който да изтрива всичко
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
