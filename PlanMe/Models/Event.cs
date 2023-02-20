using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Models
{
    public class Event
    {
        private string name;
        private DateTime date;
        private TimeOnly time;
        private string info;

        public Event(string name, DateTime date, TimeOnly time, string info)
        {
            this.Name = name;
            this.Date = date;
            this.Time = time;
            this.Info = info;
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                this.date = value;
            }
        }
        public TimeOnly Time
        {
            get { return time; }
            set
            {
                this.time = value;
            }
        }
        public string Info
        {
            get { return info; }
            set
            {
                this.info = value;
            }
        }
    }
}
