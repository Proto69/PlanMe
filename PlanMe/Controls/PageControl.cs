namespace PlanMe.Controls
{
    public static class PageControl
    {
        private static MainForm mainForm = MainModels.form;
        private static Panel panel1 = mainForm.Controls["panel1"] as Panel;

        //Opens AddAPlan control
        public static void AddAPlan()
        {
            ChangeControlToForm(new AddAPlan());
        }
        //Opens AddATask control
        public static void AddATask()
        {
            ChangeControlToForm(new AddATask());
        }
        //Opens AddList control
        public static void AddList()
        {
            ChangeControlToForm(new AddList());
        }
        //Opens Calendar control
        public static void Calendar()
        {
            ChangeControl(new Calendar(), panel1);
        }
        //Opens ListsMainScreen control
        public static void ListsMainScreen()
        {
            ChangeControl(new ListsMainScreen(), panel1);
        }
        //Opens LogIn control
        public static void LogIn()
        {
            ChangeControl(new LogIn(), panel1);
        }
        //Opens MainScreen control
        public static void MainScreen()
        {
            ChangeControl(new MainScreen(), panel1);
        }
        //Opens Plans control
        public static void Plans()
        {
            ChangeControl(new Plans(), panel1);
        }
        //Opens SeeAPlan control
        public static void SeeAPlan()
        {
            ChangeControl(new SeeAPlan(), panel1);
        }
        //Opens SignUp control
        public static void SignUp()
        {
            ChangeControl(new SignUp(), panel1);
        }
        //Opens StartPage control
        public static void StartPage()
        {
            ChangeControl(new StartPage(), panel1);
        }
        //Opens TaskSreen control
        public static void TaskScreen()
        {
            TaskScreen lists = new TaskScreen();
            ChangeControl(lists, panel1);

            //Sets main model list to current list
            MainModels.lists = lists;
        }
        //Opens WelcomePage control
        public static void WelcomePage()
        {
            ChangeControl(new WelcomePage(), panel1);
        }
        //Method for changing controls by given control and opens it in the given panel
        private static void ChangeControl(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Dock = DockStyle.Fill;

            panel.Controls.Add(control);
        }

        //Method for changing control to form by given control
        private static void ChangeControlToForm(UserControl control)
        {
            PopUpForm popUpForm = new PopUpForm();
            Panel panel = popUpForm.Controls["panel1"] as Panel;
            panel.Dock = DockStyle.Fill;

            ChangeControl(control, panel);

            popUpForm.Show();
        }
    }
}
