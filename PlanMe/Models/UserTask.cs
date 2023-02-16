using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Models
{
    public class UserTask
    {
        private string text;
        private bool isDone;

        public UserTask(string name)
        {
            this.Text = name;
            IsDone = false;
        }

        public void Complete()
        {
            //Checks if users's task is done
            if (isDone)
                throw new InvalidOperationException("This task is already done!");
            isDone = true;
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
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
