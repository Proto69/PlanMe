using PlanMe.Models;

namespace PlanMe
{
    //Model for user
    public class User
    {
        private string username;
        private string password;
        private List<Event> events;
        private List<UserTask> tasks;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            events = new List<Event>();
            tasks = new List<UserTask>();
        }

        public bool AddEvent(Event action)
        {
            throw new NotImplementedException();
        }
        public bool RemoveEvent(Event action)
        {
            throw new NotImplementedException();
        }
        public bool AddTask(UserTask task)
        {
            throw new NotImplementedException();
        }
        public bool RemoveTask(UserTask task)
        {
            throw new NotImplementedException();
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }


    }
}