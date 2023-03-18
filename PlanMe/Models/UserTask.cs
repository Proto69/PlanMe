namespace PlanMe.Models
{
    public class UserTask
    {
        private string text;
        private bool isDone;

        //Constructor wtih only parameter for the text of the task that has default value for isDone that is false;
        public UserTask(string text) : this(text, false) { }
        
        //Constructor with params
        public UserTask(string text, bool isDone)
        {
            this.Text = text;
            this.IsDone = isDone;
        }

        //Getters and Setters
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
