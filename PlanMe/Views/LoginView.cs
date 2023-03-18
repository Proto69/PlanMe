namespace PlanMe.Views
{
    public class LoginView
    {
        //Reads from the LogIn control and check if the user exist
        public static void ReadInfo(string username, string password)
        {
            DataControl.CheckUser(username, password);
        }
    }
}
