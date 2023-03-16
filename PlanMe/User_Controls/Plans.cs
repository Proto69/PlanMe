using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMe.User_Controls
{
    public partial class Plans : UserControl
    {
        public Plans()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            PageControl.AddAPlan();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PageControl.SeeAPlan();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PageControl.Calendar();

        }
    }
}
