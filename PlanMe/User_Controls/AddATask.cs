namespace PlanMe.User_Controls
{
    public partial class AddATask : UserControl
    {
        public AddATask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddATaskView.CreateTask(text.Text);
                MainModels.tasks.Tasks.Add(new(text.Text));
                MainModels.lists.DisplayAllTasks();
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
