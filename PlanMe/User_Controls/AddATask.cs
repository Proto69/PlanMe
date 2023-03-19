namespace PlanMe.User_Controls
{
    public partial class AddATask : UserControl
    {
        public AddATask()
        {
            InitializeComponent();
        }

        //Activates when the button is clicked
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            //Trys to create task, add the task to main model and then to display it and throws exception if something can't be done
            try
            {
                //Creates task
                var newTask = new UserTask(NameOfTaskBox.Text);
                AddATaskView.CreateTask(NameOfTaskBox.Text);

                //Adds the task to the main model for the current user
                MainModels.tasks.Tasks.Add(newTask);

                //Displays the new task
                MainModels.lists.DisplayAllTasks();
                MessageView.ShowSuccess("You successfully added a task!");
            }
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }
        }
    }
}
