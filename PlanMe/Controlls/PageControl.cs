﻿using PlanMe.Models;
using PlanMe.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMe.Controlls
{
    public static class PageControl
    {
        private static MainForm mainForm = MainModels.form;
        private static Panel panel1 = mainForm.Controls["panel1"] as Panel;
        public static void ShowMainScreen()
        {
            panel1.Controls.Clear();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(mainScreen);
        }

        public static void ShowSignUp()
        {
            panel1.Controls.Clear();
            SignUp signUp = new();
            signUp.Dock = DockStyle.Fill;
            panel1.Controls.Add(signUp);
        }

        public static void ShowExistingList()
        {
            panel1.Controls.Clear();
            ExistingList lists = new();
            MainModels.lists = lists;
            lists.Dock = DockStyle.Fill;
            panel1.Controls.Add(lists);
        }

        public static void ShowAddATask()
        {
            panel1.Controls.Clear();
            AddATaskForm tasks = new();
            tasks.Dock = DockStyle.Fill;
            panel1.Controls.Add(tasks);
        }
    }
}
