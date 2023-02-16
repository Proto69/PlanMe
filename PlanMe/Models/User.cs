using PlanMe.Data;
using PlanMe.Models;
using System.Text.RegularExpressions;
using System.Linq;

namespace PlanMe
{
    //Model for user
    public class User
    {
        //The username will be used as id
        private string username;
        private string password;
        private List<Event> events;
        private List<UserTask> tasks;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            events = EventData.GetAll(username);
            tasks = TaskData.GetAll(username);
        }

        public bool AddEvent(Event action)
        {
            events.Add(action);
            return EventData.Upload(action, Username);
        }

        public bool RemoveEvent(Event action)
        {
            events.Remove(action);
            return EventData.Delete(action);
        }

        public bool AddTask(UserTask task)
        {
            tasks.Add(task);
            return TaskData.Upload(task, Username);
        }

        public bool RemoveTask(UserTask task)
        {
            tasks.Remove(task);
            return TaskData.Delete(task);
        }

        //How to search these two
        public Event GetEvent()
        {
            throw new NotImplementedException();
        }

        public UserTask GetTask()
        {
            throw new NotImplementedException();
        }

        public string Username
        {
            get { return username; }
            set
            {
                //Checks the lenght of the username if it is valid (if it is longer than 3 and shorter than 50 letters)
                if (3 <= value.Length && value.Length <= 50) 
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("Username is not the right length!");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                //Checks the password if it is valid (if it contains upper case letter or number)
                if (Regex.IsMatch(value, "[A-Z0-9]"))
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("Password does not contain upper case letter or number!");
                }
            }
        }


    }
}