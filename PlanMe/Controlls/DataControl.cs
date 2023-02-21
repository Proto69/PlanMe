using PlanMe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Controlls
{
    public static class DataControl
    {
        //Creates user by getting name and pass from the view
        public static bool CreateUser(string name, string pass)
        {
            //We will set a global variable to this user instance
            User user = new User(name, pass);
            return UserData.Create(user);
        }

        //Updates user's password
        public static void UpdateUserPassword(User user)
        {
            throw new NotImplementedException();
        }

        //Deletes a user specified, from the view
        public static void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
