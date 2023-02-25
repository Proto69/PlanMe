using Google.Protobuf.Collections;
using PlanMe.Models;
using PlanMe.User_Controls;
using PlanMe.Views;

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
            ShowSignUp();
        }

        public void ShowMainScreen()
        {
            panel1.Controls.Clear();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(mainScreen);
        }

        public void ShowSignUp()
        {
            panel1.Controls.Clear();
            SignUp signUp = new();
            signUp.Dock = DockStyle.Fill;
            panel1.Controls.Add(signUp);
        }

        public void ShowExistingList()
        {
            panel1.Controls.Clear();
            ExistingList lists = new();
            MainModels.lists = lists;
            lists.Dock = DockStyle.Fill;
            panel1.Controls.Add(lists);
        }

        public void ShowAddATask()
        {
            panel1.Controls.Clear();
            AddATaskForm tasks = new();
            tasks.Dock = DockStyle.Fill;
            panel1.Controls.Add(tasks);
        }
    }
}