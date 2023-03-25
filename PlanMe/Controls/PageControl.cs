namespace PlanMe.Controls
{
    public static class PageControl
    {
        private static MainForm mainForm = MainModels.form;
        private static Panel panel1 = mainForm.Controls["panel1"] as Panel;

        public static void AddAPlan()
        {
            ChangeControlToForm(new AddAPlan());
        }
        public static void AddATask()
        {
            ChangeControlToForm(new AddATask());
        }
        public static void AddList()
        {
            ChangeControlToForm(new AddAList());
        }
        public static void ListsMainScreen()
        {
            ChangeControl(new ListsMainScreen(), panel1);
        }
        public static void LogIn()
        {
            ChangeControl(new LogIn(), panel1);
        }
        public static void MainScreen()
        {
            ChangeControl(new MainScreen(), panel1);
        }
        public static void Plans()
        {
            ChangeControl(new Plans(), panel1);
        }
        public static void SeeAPlan()
        {
            ChangeControl(new SeeAPlan(), panel1);
        }
        public static void SignUp()
        {
            ChangeControl(new SignUp(), panel1);
        }
        public static void StartPage()
        {
            ChangeControl(new StartPage(), panel1);
        }
        public static void TaskScreen()
        {
            TaskScreen lists = new TaskScreen();
            ChangeControl(lists, panel1);
            MainModels.lists = lists;
        }
        public static void WelcomePage()
        {
            ChangeControl(new WelcomePage(), panel1);
        }
        private static void ChangeControl(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Dock = DockStyle.Fill;

            panel.Controls.Add(control);
        }

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
