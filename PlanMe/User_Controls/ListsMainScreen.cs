using Microsoft.VisualBasic;
using PlanMe.Models;
using System.Data;
using System.Windows.Forms;

namespace PlanMe.User_Controls
{
    public partial class ListsMainScreen : UserControl
    {
        DataTable table = new();
        List<ListOfTasks> lists = ListOfTasksData.GetAll(MainModels.user.Username);

        public ListsMainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageControl.AddList();
        }

        private void ListsMainScreen_Load(object sender, EventArgs e)
        {
            FillListOfTasksDataGridView();
            ListOfTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListOfTasks.MultiSelect = false;
        }

        public void FillListOfTasksDataGridView()
        {
            table.Columns.Add("Name", typeof(string));


            for (int i = 0; i < lists.Count; i++)
            {
                table.Rows.Add(lists[i].Name);
            }

            ListOfTasks.DataSource = table;
        }

        //Sus method
        private void CheckForUpdate(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = ListOfTasks.Rows[rowIndex];

            DataGridViewCell cell = ListOfTasks.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string oldName = lists[rowIndex].Name;

            if (cell.Value.ToString() == "")
            {
                ListOfTasksData.Remove(new ListOfTasks(oldName, MainModels.user.Username));
                ListOfTasks.Rows.RemoveAt(rowIndex);
            }
            else
            {

                string newName = row.Cells[1].Value.ToString();

                ListOfTasksData.Update(oldName, newName);

                for (int i = 0; i < lists.Count; i++)
                {
                    if (lists[i].Name == oldName)
                    {
                        lists[i].Name = newName;
                        break;
                    }
                }

            }
        }

        private void ListOfTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckForUpdate(e);
        }
    }
}
