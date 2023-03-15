using Google.Protobuf.Collections;
using PlanMe.Models;

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
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Done?", typeof(bool));


            for (int i = 0; i < tasks.Count; i++)
            {
                table.Rows.Add(tasks[i].Text, tasks[i].IsDone);
            }

            dataGridView1.DataSource = table;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PageControl.ListsMainScreen();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewCheckBoxCell)
            {
                string name = tasks[rowIndex].Text;

                if (cell.Value.ToString() == "")
                {
                    TaskData.Delete(new UserTask(name), MainModels.tasks.Name);
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    TaskData.Update(new UserTask(name, (bool)row.Cells[1].Value), MainModels.tasks.Name);

                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i].Text == name)
                        {
                            tasks[i].IsDone = !(bool)row.Cells[1].Value;
                            break;
                        }
                    }

                }
            }
        }
    }
}
