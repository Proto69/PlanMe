﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlanMe.Models
{
    public class UserTask
    {
        private string text;
        private bool isDone;

        public UserTask(string text) : this(text, true)
        {

        }

        public UserTask(string text, bool isDone)
        {
            this.Text = text;
            this.IsDone = isDone;
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

        public override string ToString()
        {
            return $"{text} {isDone}";
        }
    }
}
