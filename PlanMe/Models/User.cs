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
        private List<ListOfTasks> allTasks;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            events = EventData.GetAll(username);
            AllTasks = ListOfTasksData.GetAll(username);
        }

        //Adds event to the database for current user
        public bool AddEvent(Event action)
        {
            events.Add(action);
            return EventData.Upload(action, Username);
        }

        //Removes event from the database for the current user
        public bool RemoveEvent(Event action)
        {
            events.Remove(action);
            return EventData.Delete(action);
        }

        //Adds task to the database for current user
        public bool AddListOfTasks(ListOfTasks task)
        {
            AllTasks.Add(task);
            return ListOfTasksData.Upload(task);
        }

        //Removes task from the database for the current user
        public bool RemoveListOfTasks(ListOfTasks task)
        {
            AllTasks.Remove(task);
            return ListOfTasksData.Remove(task);
        }

        public ListOfTasks GetListOfTasks(string name)
        {
            ListOfTasks list = new(name, this.Username);
            list.Tasks = TaskData.GetAll(name, this.Username);
            return list;
        }

        //Gets the event by date
        public Event GetEvent(DateOnly date)
        {
            throw new NotImplementedException();
        }

        //Gets the event by name
        public Event GetEvent(string name)
        {
            throw new NotImplementedException();
        }

        public string Username
        {
            get { return username; }
            set
            {
                //Checks the lenght of the username if it is valid (if it is longer than 3 and shorter than 50 letters)
                if (3 > value.Length || value.Length > 50)
                    throw new ArgumentException("Username is not the right length!");
                username = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 8)
                    throw new ArgumentException("The password is too short!");
                //Checks the password if it is valid (if it contains upper case letter or number)
                if (Regex.IsMatch(value, "[A-Z0-9]"))
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password does not contain upper case letter or number!");
                }
            }
        }

        public List<ListOfTasks> AllTasks { get => allTasks; set => allTasks = value; }

        public override string? ToString()
        {
            return $"{username} => {password}";
        }
    }
}