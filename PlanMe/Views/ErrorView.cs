namespace PlanMe.Views
{
    public static class ErrorView
    {
        //Shows an error message with a Message Box
        public static void ShowError(string message)
        {
            //Трябва да го променим, да е на form 
            MessageBox.Show(message, "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}