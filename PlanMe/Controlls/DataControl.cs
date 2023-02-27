using PlanMe.Data;
using PlanMe.Models;
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
        public static void CreateUser(string name, string pass)
        {
            //We will set a global variable to this user instance
            User user = new User(name, pass);
            MainModels.user = user;
            UserData.Create(user);
        }

        //Use for LogIn page, checks if the values are correct
        //and sets the global variable to this user instance
        public static void CheckUser(string username, string password)
        {
            User user = UserData.Check(username, password);
            MainModels.user = user;
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

        public static void CreateTask(string text, string nameOfList)
        {
            UserTask task = new UserTask(text);
            TaskData.Upload(task, nameOfList, MainModels.user.Username);
        }

        public static bool UpdateTask(string text,string nameofList, bool isDone)
        {
            UserTask task = new UserTask(text, isDone);
            return TaskData.Update(task, nameofList, MainModels.user.Username);
        }
    }
}
