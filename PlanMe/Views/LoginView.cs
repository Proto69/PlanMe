namespace PlanMe.Views
{
    public class LoginView
    {
        public static void ReadInfo(string username, string password)
        {
            DataControl.CheckUser(username, password);
        }
    }
}
