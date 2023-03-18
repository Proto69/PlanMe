namespace PlanMe.Views
{
    public static class AddATaskView
    {
        //Creates a task with text
        public static void CreateTask(string text)
        {
            //Checks if the text is valid and throws exception if it is not
            if (text.Length == 0)
                throw new ArgumentException("You cannot create a task without text!");
            DataControl.CreateTask(text, MainModels.tasks.Name);
        }
    }
}
