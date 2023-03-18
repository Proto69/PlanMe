namespace PlanMe.Models
{
    //Model for user
    public class User
    {
        private int id;
        private string username;
        private string password;
        private List<Event> events;
        private List<ListOfTasks> allTasks;

        //Constructor with params
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        //Filling the data for the user
        public void FillEventsAndTasks()
        {
            Events = EventData.GetAll();
            AllTasks = ListOfTasksData.GetAll(username);
        }

        //Getters and Setters
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
        public List<Event> Events { get => events; set => events = value; }
        public int Id { get => id; set => id = value; }

        //Override ToString
        public override string? ToString()
        {
            return $"{username} => {password}";
        }
    }
}