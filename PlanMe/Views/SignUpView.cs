namespace PlanMe.Views
{
    public static class SignUpView
    {
        //Reads from SignUp control and creates user if the values are valid
        public static void ReadInfo(string name, string pass, string repPass)
        {
            //Checks if the password and the repeated password are the same
            if(pass != repPass)
                throw new ArgumentException("Passwords does not match!");
            
            DataControl.CreateUser(name, pass);
        }
    }
}
