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
    public partial class ScheduleTips : UserControl
    {
        public ScheduleTips()
        {
            InitializeComponent();
        }

        public void ScheduleTips_Click(object sender, EventArgs e)
        {
            //Tutorials
            //  Basic Navigation
            
            //General advice
            //  Schedule Downtime
            //  Prioritize Events
        }

        private void ScheduleTips_Load(object sender, EventArgs e)
        {
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                label1.ForeColor = SystemColors.WindowText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                label1.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {

            }
            else if (ComponentModel.savetheme == 3)
            {

            }
            else if (ComponentModel.savetheme == 4)
            {

            }
        }
    }
}
