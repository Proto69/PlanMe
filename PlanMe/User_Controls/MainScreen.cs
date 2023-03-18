namespace PlanMe
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            //Sets PhraseLabel to today's phrase
            PhraseLabel.Text = PhraseData.GetPhrase();
        }

        //Activates after clicking on the PlansButton
        private void PlansButton_Click_1(object sender, EventArgs e)
        {
            PageControl.Plans();
        }

        //Activates after clicking on the ListsButton
        private void ListsButton_Click_1(object sender, EventArgs e)
        {
            PageControl.ListsMainScreen();
        }

        //Activates after clicking on the InfoButton
        private void InfoButton_Click_1(object sender, EventArgs e)
        {
            PageControl.WelcomePage();
        }
    }
}
