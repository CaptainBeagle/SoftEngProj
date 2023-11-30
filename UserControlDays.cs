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
        string eventrep = ComponentModel.Rep;
        public View Owner {  get; set; }
        public UserControlDays()
        {
            InitializeComponent();
        }
        
        public void Days(int numday)
        {
            lbdays.Text = numday + "";
            //if the EventView corresponding to this day contains an instance of UCModel, make color not standard and still stand out. If not, make color standard.
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                lbdays.ForeColor = SystemColors.WindowText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                lbdays.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                lbdays.ForeColor = SystemColors.Control;
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            EventView.CurrentDay = lbdays.Text;
            EventView ef = new EventView();
            //Use eventrep here
            //call ef.AddEvent([info from ComponentModel here]) depending on repeatability
            if(eventrep == "Every day")
            {
                ef.AddEvent(ComponentModel.Ename,ComponentModel.Elocation,ComponentModel.Ecategory,ComponentModel.Estart,ComponentModel.Eend,ComponentModel.Erepeat,ComponentModel.Eremind);
            }
            DateTime now = new DateTime(Owner.Year, Owner.Month, Convert.ToInt32(lbdays.Text));
            if(eventrep == "Weekends")
            {
                if ((now.DayOfWeek == DayOfWeek.Sunday) || (now.DayOfWeek == DayOfWeek.Saturday))
                {
                    ef.AddEvent(ComponentModel.Ename, ComponentModel.Elocation, ComponentModel.Ecategory, ComponentModel.Estart, ComponentModel.Eend, ComponentModel.Erepeat, ComponentModel.Eremind);
                }
            }
            //Do the same for Weekdays and Once a week
            if(eventrep == "Weekdays")
            {
                if ((now.DayOfWeek == DayOfWeek.Monday) || (now.DayOfWeek == DayOfWeek.Tuesday) || (now.DayOfWeek == DayOfWeek.Wednesday) || (now.DayOfWeek == DayOfWeek.Thursday) || (now.DayOfWeek == DayOfWeek.Friday))
                {
                    ef.AddEvent(ComponentModel.Ename, ComponentModel.Elocation, ComponentModel.Ecategory, ComponentModel.Estart, ComponentModel.Eend, ComponentModel.Erepeat, ComponentModel.Eremind);
                }
            }
            //Only problem with this method is that it can only handel one repeated event at a time, but limited functionality is better than none.
            
            ef.Show();
        }
    }
}
