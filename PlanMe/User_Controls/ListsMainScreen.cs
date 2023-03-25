namespace PlanMe.User_Controls
{
    public partial class ListsMainScreen : UserControl
    {
        DataTable table = new();
        List<ListOfTasks> lists = MainModels.user.AllTasks;

        public ListsMainScreen()
        {
            InitializeComponent();
        }

        // Loads ListsMainScreen control
        private void ListsMainScreen_Load(object sender, EventArgs e)
        {
            FillListOfTasksDataGridView();

            // Auto resizeing mode (resizes the columns to fit perfect)
            ListOfTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Doesn't allow to choos more than 1 row
            ListOfTasks.MultiSelect = false;
        }

        // Fills the table
        public void FillListOfTasksDataGridView()
        {
            // Creates column named "Name" where will be displayed all lists names
            table.Columns.Add("Name", typeof(string));

            // Fills the table with the names
            for (int i = 0; i < lists.Count; i++)
            {
                table.Rows.Add(lists[i].Name);
            }

            ListOfTasks.DataSource = table;
        }

        // Checks if there is an update in the table
        private void CheckForUpdate(DataGridViewCellEventArgs e)
        {
            // Takes the index of which row was changed
            int rowIndex = e.RowIndex;

            // Gets the whole row
            DataGridViewRow row = ListOfTasks.Rows[rowIndex];

            // Gets the cell which is updated
            DataGridViewCell cell = ListOfTasks.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Gets the old value fron the cell
            string oldName = lists[rowIndex].Name;

            // Checks if the cell is empty
            if (cell.Value.ToString() == "")
            {
                // Takes current list
                var currentList = new ListOfTasks(oldName, MainModels.user.Username);

                // Removes the list from the database
                ListOfTasksData.Remove(currentList);

                // Removes the list from tha main model
                MainModels.user.AllTasks.Remove(currentList);

                // Removes the list from the table
                ListOfTasks.Rows.RemoveAt(rowIndex);
            }
            else
            {
                try
                {
                    // Gets the new value
                    string newName = row.Cells[1].Value.ToString();

                    // Updates the old value with the new one
                    ListOfTasksData.Update(oldName, newName);

                    // Updates the old value in the main model
                    for (int i = 0; i < lists.Count; i++)
                    {
                        if (lists[i].Name == oldName)
                        {
                            lists[i].Name = newName;
                            break;
                        }
                    }
                }
                // Catches when there is a duplicate in primary keys in database
                catch (MySqlException)
                {
                    MessageView.ShowError("There is already a list with this name!");
                }
                // Catches any other error
                catch (Exception ex)
                {
                    MessageView.ShowError(ex.Message);
                }
            }
        }

        // Activates after changing the cell's value and press 'enter'
        private void ListOfTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CheckForUpdate(e);
        }

        // Activates after clicking on the CreateListButton
        private void CreateListButton_Click(object sender, EventArgs e)
        {
            PageControl.AddList();
        }

        // Activates after clicking on the table (on cell)
        private void ListOfTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if the clicked cell is the button cell
            if (ListOfTasks.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Sets main model task to the right value
                MainModels.tasks = lists[e.RowIndex];

                // Opens TaskScreen control
                PageControl.TaskScreen();
            }
        }

        // Activates after click on the BackButton
        private void BackButton_Click(object sender, EventArgs e)
        {
            PageControl.MainScreen();
        }
    }
}
