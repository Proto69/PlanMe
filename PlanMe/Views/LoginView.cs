using PlanMe.Controlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
