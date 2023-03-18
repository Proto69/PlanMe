namespace PlanMe.Models
{
    //Models to use over the whole app
    public static class MainModels
    {
        //The user that is currently logged in
        public static User user = null;

        //The main form that is loaded
        public static MainForm form = null;

        //The current task screen that is in use
        public static TaskScreen lists = null;

        //The current list of tasks that is opened on the TaskScreen
        public static ListOfTasks tasks = null;
    }
}
