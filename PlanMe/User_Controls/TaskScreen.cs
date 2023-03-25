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
            label1.Text = MainModels.tasks.Name;
        }


        // Displays all tasks in the table
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

                TaskDataGridView.DataSource = table;
            }
            catch
            {
                table.Clear();
                for (int i = 0; i < tasks.Count; i++)
                {
                    table.Rows.Add(tasks[i].Text, tasks[i].IsDone);
                }

                TaskDataGridView.DataSource = table;
            }
        }

        // Activates after changing the cell value ant pressing 'enter'
        private void TaskDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Takes the index of the row for the changed cell
                int rowIndex = e.RowIndex;

                // Takes the whole row that has changes
                DataGridViewRow row = TaskDataGridView.Rows[rowIndex];

                // Takes the cell that is changed
                DataGridViewCell cell = TaskDataGridView.Rows[rowIndex].Cells[e.ColumnIndex];

                string nameChecker = cell.Value.ToString();
                bool checkBoxChecker = (bool)row.Cells[1].Value;
                string name = tasks[rowIndex].Text;


                // Checks if the task has to be deleted or updated
                if (nameChecker == "" && checkBoxChecker is true)
                {
                    // Deletes the task from the database
                    TaskData.Delete(new UserTask(name), MainModels.tasks.Name);

                    // Deletes the task from the main model
                    tasks.RemoveAt(rowIndex);
                    MainModels.tasks.Tasks = tasks;

                    // Deletes the task from the table
                    TaskDataGridView.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    // Updates the task in the database
                    TaskData.Update(new UserTask(name, (bool)row.Cells[1].Value), MainModels.tasks.Name);

                    // Updates the task in the main model
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
            // Catches when there is a duplicate in primary keys in database
            catch (MySqlException)
            {
                MessageView.ShowError("There is already a task with this name!");
            }
            // Catches any other error
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }

        }

        private void TaskScreen_Load(object sender, EventArgs e)
        {
            // Autosize mode activated (resizes the columns to fit perfectly)
            TaskDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Doesn't allow to choose more than one cell/row
            TaskDataGridView.MultiSelect = false;
        }

        // Activates after clicking on the BackButton
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Opens the ListsMainScreen controler
            PageControl.ListsMainScreen();
        }

        // Activates after clicking on the AddTaskButton
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            // Opens the AddATask controler
            PageControl.AddATask();
        }

        // Activates after clicking on the SaveButton
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Opens the LisfsMainScreen controler
            PageControl.ListsMainScreen();
        }
    }
}
