namespace PlanMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            MainModels.form = this;
            PageControl.StartPage();


            //Change timer's seconds
            System.Timers.Timer timer = new System.Timers.Timer(4500);

            timer.Elapsed += OnTimerElapsed;
            timer.Start();


        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {

            this.Invoke((MethodInvoker)delegate { PageControl.LogIn(); });

            ((System.Timers.Timer)sender).Stop();
        }
    }
}