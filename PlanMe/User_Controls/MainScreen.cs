namespace PlanMe
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            label2.Text = PhraseData.GetPhrase();
        }

        private void listsButton_Click(object sender, EventArgs e)
        {
            PageControl.ListsMainScreen();
        }

        private void plansButton_Click(object sender, EventArgs e)
        {
            PageControl.Plans();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            PageControl.WelcomePage();
        }
    }
}
