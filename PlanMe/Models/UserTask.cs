using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Models
{
    public class UserTask
    {
        private string name;
        private bool isDone;

        public UserTask(string name)
        {
            this.Name = name;
            IsDone = false;
        }

        public void Complete()
        {
            if (isDone)
                throw new InvalidOperationException("This task is already done!");
            isDone = true;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public bool IsDone
        {
            get { return isDone; }
            set
            {
                isDone = value;
            }
        }
    }
}
