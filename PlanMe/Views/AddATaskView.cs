namespace PlanMe.Views
{
    public static class AddATaskView
    {
        public static void CreateTask(string text)
        {
            if (text.Length == 0)
                throw new ArgumentException("You cannot create a task without text!");
            DataControl.CreateTask(text, MainModels.tasks.Name);
        }
    }
}
