using PlanMe.Controlls;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Views
{
    public static class AddATaskView
    {
        public static void CreateTask(string text)
        {
            if (text.Length == 0)
                throw new ArgumentException("You cannot create a task without text!");
            DataControl.CreateTask(text);
        }
    }
}
