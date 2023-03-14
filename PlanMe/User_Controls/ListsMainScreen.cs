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

            //Sus
            string oldValue = cell.OwningRow.Cells[e.ColumnIndex].Value.ToString();

            //doesn't check correct with both of them
            //if (cell.Value == null || cell.Value == "")
            if (row.Cells[1].Value is null || row.Cells[1].Value == "")
            {
                ListOfTasksData.Remove(new ListOfTasks(row.Cells[1].Value.ToString(), MainModels.user.Username));
                ListOfTasks.Rows.RemoveAt(rowIndex);
            }
            else
            {

                object newValue = cell.Value;


                string newName = row.Cells[1].Value.ToString();
                string oldName = lists.Where(x => x.Name == oldValue).ToString();


                ListOfTasksData.Update(lists[rowIndex].Name, newName);

            }
        }

        private void ListOfTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckForUpdate(e);
        }
    }
}
