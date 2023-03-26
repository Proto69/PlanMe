namespace PlanMe.Controls
{
    public static class DataControl
    {
        //Creates user by getting name and password from the view
        public static void CreateUser(string name, string pass)
        {
            //We will set a global variable to this user instance
            User user = new User(name, pass);
            user.Events = new();
            user.AllTasks = new();
            MainModels.user = user;
            UserData.Create(user);
        }

        //Use for LogIn page, checks if the values are correct
        //and sets the global variable to this user instance
        public static void CheckUser(string username, string password)
        {
            User user = UserData.Check(username, password);
            MainModels.user = user;
        }

        //Creates task by getting text and name for the current list
        public static void CreateTask(string text, string nameOfList)
        {
            UserTask task = new UserTask(text);
            TaskData.Upload(task, nameOfList);
        }
    }
}
