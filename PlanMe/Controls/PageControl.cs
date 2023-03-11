namespace PlanMe.Controls
{
    public static class PageControl
    {
        private static MainForm mainForm = MainModels.form;
        private static Panel panel1 = mainForm.Controls["panel1"] as Panel;

        public static void MainScreen()
        {
            panel1.Controls.Clear();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(mainScreen);
        }
        public static void SignUp()
        {
            panel1.Controls.Clear();
            SignUp signUp = new();
            signUp.Dock = DockStyle.Fill;
            panel1.Controls.Add(signUp);
        }
        public static void LogIn()
        {
            panel1.Controls.Clear();
            LogIn login = new();
            login.Dock = DockStyle.Fill;
            panel1.Controls.Add(login);
        }
        public static void WelcomePage()
        {
            panel1.Controls.Clear();
            WelcomePage page = new();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Add(page);
        }
        public static void ExistingList()
        {
            panel1.Controls.Clear();
            TaskScreen lists = new();
            MainModels.lists = lists;
            lists.Dock = DockStyle.Fill;
            panel1.Controls.Add(lists);
        }
        public static void AddATask()
        {
            panel1.Controls.Clear();
            PopUpForm tasks = new();
            tasks.Dock = DockStyle.Fill;
            panel1.Controls.Add(tasks);
        }
    }
}
