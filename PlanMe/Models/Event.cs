using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe.Models
{
    public class Event : IComparable<Event>
    {
        private string name;
        private DateTime date;
        private TimeOnly time;
        private string info;

        public Event(string name, DateTime date, string time, string info)
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
                if (value.Length > 150)
                    throw new ArgumentException("The name is too long!");
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
        public string Time
        {
            get { return time.ToString("HH:mm:ss"); }
            set
            {
                this.time = TimeOnly.ParseExact(value, "HH:mm:ss");
            }
        }
        public string Info
        {
            get { return info; }
            set
            {
                if (value == null)
                    this.info = "No additional info!";
                else
                    this.info = value;
            }
        }

        public int CompareTo(Event? other)
        {
            bool name = this.Name == other.Name;
            bool date = this.Date == other.Date;
            bool time = this.Time == other.Time;

            if (name && time && date) return 0;
            return 1;
        }

        public override string? ToString()
        {
            return $"{Name} on {Date} at {Time}";
        }
    }
}
