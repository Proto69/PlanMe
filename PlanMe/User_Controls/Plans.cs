namespace PlanMe.User_Controls
{
    public partial class Plans : UserControl
    {
        public Plans()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            PageControl.AddAPlan();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PageControl.SeeAPlan();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PageControl.Calendar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
