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

        private void ListOfTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckForUpdate(e);
        }

        private void CheckForUpdate(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = ListOfTasks.Rows[rowIndex];

            DataGridViewCell cell = ListOfTasks.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ListOfTasks oldValue = (ListOfTasks)cell.OwningRow.Cells[e.ColumnIndex].Value;
            object newValue = cell.Value;


            string newName = row.Cells[0].Value.ToString();
            string oldName = lists.Where(x => x.Name == oldValue.Name).ToString();

            if (!newName.Equals(oldName))
            {
                ListOfTasksData.Update(lists[rowIndex].Name, newName);
            }
        }

        private void ListOfTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckForUpdate(e);
        }
    }
}
