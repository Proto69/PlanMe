using Google.Protobuf.Collections;
using PlanMe.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlanMe.User_Controls
{
    public partial class TaskScreen : UserControl
    {
        private DataTable table = new();
        private List<UserTask> tasks = MainModels.tasks.Tasks;

        public TaskScreen()
        {
            InitializeComponent();

            DisplayAllTasks();
        }

        public void DisplayAllTasks()
        {
            try
            {
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Done?", typeof(bool));


                for (int i = 0; i < tasks.Count; i++)
                {
                    table.Rows.Add(tasks[i].Text, tasks[i].IsDone);
                }

                dataGridView1.DataSource = table;
            }
            catch
            {
                table.Clear();
                for (int i = 0; i < tasks.Count; i++)
                {
                    table.Rows.Add(tasks[i].Text, tasks[i].IsDone);
                }

                dataGridView1.DataSource = table;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PageControl.ListsMainScreen();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            DataGridViewCell cell = dataGridView1.Rows[rowIndex].Cells[e.ColumnIndex];
            string nameChecker = cell.Value.ToString();
            bool checkBoxChecker = (bool)row.Cells[1].Value;
            string name = tasks[rowIndex].Text;

            if (nameChecker == "" && checkBoxChecker is true)
            {

                TaskData.Delete(new UserTask(name), MainModels.tasks.Name);
                //var toRemove = new UserTask(name, checkBoxChecker);
                tasks.RemoveAt(rowIndex);
                MainModels.tasks.Tasks = tasks;

                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                TaskData.Update(new UserTask(name, (bool)row.Cells[1].Value), MainModels.tasks.Name);
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (tasks[i].Text == name)
                    {
                        tasks[i].IsDone = (bool)row.Cells[1].Value;
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageControl.AddATask();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaskScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
