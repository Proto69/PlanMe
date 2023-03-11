namespace PlanMe.Views
{
    public static class SignUpView
    {
        public static void ReadInfo(string name, string pass, string repPass)
        {
            if(pass != repPass)
                throw new ArgumentException("Passwords does not match!");
            
            DataControl.CreateUser(name, pass);
        }
    }
}
