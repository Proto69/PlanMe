namespace PlanMe.User_Controls
{
    public partial class AddList : UserControl
    {
        public AddList()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            //Trys to create new ListOfTasks and then to upload it into the database
            try
            {
                //Takes params from the ListNameBox (TextBox) and the username from the main model and creates a listOfTasks
                var newList = new ListOfTasks(ListNameBox.Text, MainModels.user.Username);

                //Uploads the new list into the database
                ListOfTasksData.Upload(newList);
                
                //Puts the new list into the main model
                MainModels.user.AllTasks.Add(newList);
                
                //Opens the ListMainScreen control?
                PageControl.ListsMainScreen();
            }
            catch (Exception ex)
            {
                ErrorView.ShowError(ex.Message);
            }
        }
    }
}
