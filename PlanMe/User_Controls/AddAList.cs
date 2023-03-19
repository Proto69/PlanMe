namespace PlanMe.User_Controls
{
    public partial class AddAList : UserControl
    {
        public AddAList()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            // Tries to create new ListOfTasks and then to upload it into the database
            try
            {
                // Takes params from the ListNameBox (TextBox) and the username from the main model and creates a listOfTasks
                var newList = new ListOfTasks(ListNameBox.Text, MainModels.user.Username);

                // Uploads the new list into the database
                ListOfTasksData.Upload(newList);

                // Puts the new list into the main model
                MainModels.user.AllTasks.Add(newList);

                // Opens the ListMainScreen control
                PageControl.ListsMainScreen();

                MessageView.ShowSuccess("You successfully added a list for tasks!");
            }
            // Catches when there is a duplicate in primary keys in database
            catch (MySqlException)
            {
                MessageView.ShowError("This name is in use, choose another one!");
            }
            // Catches any other error
            catch (Exception ex)
            {
                MessageView.ShowError(ex.Message);
            }
        }
    }
}
