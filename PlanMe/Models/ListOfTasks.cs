namespace PlanMe.Models
{
    public class ListOfTasks
    {
        private List<UserTask> tasks;
        private string name;
        private string username;

        public ListOfTasks(string name, string username)
        {
            this.Name = name;
            this.Username = username;
            this.Tasks = TaskData.GetAll(name, username);
        }

        public ListOfTasks(string name) : this(name, MainModels.user.Username)
        {

        }

        public void DeleteAllTasks()
        {
            foreach (var task in tasks)
            {
                TaskData.Delete(task, this.name);
            }
            tasks = new();
        }

        public List<UserTask> Tasks { get => tasks; set => tasks = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
    }
}
