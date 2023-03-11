using PlanMe.Controls;
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
            label2.Text = PhraseData.GetPhrase();
        }

        private void listsButton_Click(object sender, EventArgs e)
        {
            //Трябва да показва друго ама още го няма
            PageControl.ExistingList();
        }

        private void plansButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
