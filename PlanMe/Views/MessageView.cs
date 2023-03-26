namespace PlanMe.Views
{
    public static class MessageView
    {
        // Shows an error message with a Message Box
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Shows a successful operation
        public static void ShowSuccess(string message)
        {
           // MessageBox.Show(message, "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}