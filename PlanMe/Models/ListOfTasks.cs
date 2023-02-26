using PlanMe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Models
{
    public class ListOfTasks
    {
        private List<UserTask> tasks;
        private string name;

        public ListOfTasks(string name, string username)
        {
            this.Name = name;
            this.Tasks = TaskData.GetAll(name, username);
        }

        public void DeleteAllTasks()
        {
            foreach (var task in tasks)
            {
                TaskData.Delete(task, this.name, MainModels.user.Username);
            }
            tasks = new();
        }

        public List<UserTask> Tasks { get => tasks; set => tasks = value; }
        public string Name { get => name; set => name = value; }
    }
}
