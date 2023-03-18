namespace PlanMe.Models
{
    public class Event
    {
        private string name;
        private DateTime date;
        private TimeOnly time;
        private string info;

        public Event()
        {
        }

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
                //Checks the length to be less than 150
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
    }
}
