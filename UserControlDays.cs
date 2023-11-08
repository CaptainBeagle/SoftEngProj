using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngProj
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        
        public void Days(int numday)
        {
            lbdays.Text = numday + "";
            //if the EventView corresponding to this day contains an instance of UCModel, make color not white and still stand out. If not, make color white.
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            EventView.CurrentDay = lbdays.Text;
            EventView ef = new EventView();
            ef.Show();
        }
    }
}
