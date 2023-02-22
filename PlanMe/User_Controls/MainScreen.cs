using PlanMe.Data;
using PlanMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMe
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            phraseBox.Text = PhraseData.GetPhrase();
        }

        private void listsButton_Click(object sender, EventArgs e)
        {
            MainUserAndForm.form.ShowExistingList();
        }

        private void plansButton_Click(object sender, EventArgs e)
        {
            MainUserAndForm.form.ShowAddATask();
        }
    }
}
