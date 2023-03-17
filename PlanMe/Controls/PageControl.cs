using System.Net.Http.Headers;

namespace PlanMe.Controls
{
    public static class PageControl
    {
        private static MainForm mainForm = MainModels.form;
        private static Panel panel1 = mainForm.Controls["panel1"] as Panel;

        public static void AddAPlan()
        {
            PopUpForm popUpForm = new PopUpForm();
            Panel panel = popUpForm.Controls["panel1"] as Panel;

            panel.Dock = DockStyle.Fill;

            ChangeControl(new AddAPlan(), panel);

            popUpForm.Show();
        }
        public static void AddATask()
        {
            PopUpForm popUpForm = new PopUpForm();
            Panel panel = popUpForm.Controls["panel1"] as Panel;
            panel.Dock = DockStyle.Fill;

            ChangeControl(new AddATask(), panel);

            popUpForm.Show();
        }
        public static void AddList()
        {
            PopUpForm popUpForm = new PopUpForm();
            Panel panel = popUpForm.Controls["panel1"] as Panel;
            panel.Dock = DockStyle.Fill;

            ChangeControl(new AddList(), panel);

            popUpForm.Show();
        }
        public static void Calendar()
        {
            ChangeControl(new Calendar(), panel1);
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
    }
}
