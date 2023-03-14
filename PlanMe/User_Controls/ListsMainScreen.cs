using PlanMe.Models;
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

            if (row.Cells[0].Value is null)
            {
                //How to delete??
                //ListOfTasksData.Remove(new(oldValue));
            }
            else
            {
                
                object newValue = cell.Value;


                string newName = row.Cells[0].Value.ToString();
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
