namespace PlanMe.Views
{
    public static class ErrorView
    {
        //Shows an error message with a Message Box
        public static void ShowError(string message)
        {
            //������ �� �� ��������, �� � �� form 
            MessageBox.Show(message, "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}