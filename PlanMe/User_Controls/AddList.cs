namespace PlanMe.User_Controls
{
    public partial class AddList : UserControl
    {
        public AddList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ListOfTasksData.Upload(new ListOfTasks(textBox1.Text, MainModels.user.Username));
                PageControl.ListsMainScreen();
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
