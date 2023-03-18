namespace PlanMe.Models
{
    public class UserTask
    {
        private string text;
        private bool isDone;

        public UserTask(string text) : this(text, false) { }
        

        public UserTask(string text, bool isDone)
        {
            this.Text = text;
            this.IsDone = isDone;
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
