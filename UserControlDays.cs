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
            //if the EventView corresponding to this day contains an instance of UCModel, make color not standard and still stand out. If not, make color standard.
            if (View.theme == 0)
            {
                this.BackColor = SystemColors.Window;
                lbdays.ForeColor = SystemColors.WindowText;
            }
            else if (View.theme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                lbdays.ForeColor = SystemColors.Control;
            }
            else if (View.theme == 2)
            {

            }
            else if (View.theme == 3)
            {

            }
            else if (View.theme == 4)
            {

            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            EventView.CurrentDay = lbdays.Text;
            EventView ef = new EventView();
            ef.Show();
        }
    }
}
