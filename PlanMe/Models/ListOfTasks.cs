namespace PlanMe.Models
{
    public class ListOfTasks
    {
        private List<UserTask> tasks;
        private string name;
        private string username;

        //Constructor with params
        public ListOfTasks(string name, string username)
        {
            this.Name = name;
            this.Username = username;
            this.Tasks = TaskData.GetAll(name);
        }

        //Constructor with only one param that gets the second from the main model
        public ListOfTasks(string name) : this(name, MainModels.user.Username)
        {

        }

        //Method for deleting all tasks
        public void DeleteAllTasks()
        {
            foreach (var task in tasks)
            {
                TaskData.Delete(task, this.name);
            }
            tasks = new();
        }

        //Getters and Setters
        public List<UserTask> Tasks { get => tasks; set => tasks = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
    }
}
