using System;
using PlanMe.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Views
{
    public static class SignUpView
    {
        public static void ReadInfo(string name, string pass, string repPass)
        {
            
            if(pass != repPass)
            {
                throw new ArgumentException("Passwords does not match!");
            }
            DataController.CreateUser(name, pass);
        }
    }
}
