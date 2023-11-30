using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngProj
{
    public partial class TipView : Form
    {
        public View O {  get; set; }
        public ScheduleTips c {  get; set; }
        public TipView()
        {
            InitializeComponent();

            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Menu;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                label3.ForeColor = SystemColors.ControlText;
                label4.ForeColor = SystemColors.ControlText;
                label5.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label8.ForeColor = SystemColors.ControlText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                label3.ForeColor = SystemColors.Control;
                label4.ForeColor = SystemColors.Control;
                label5.ForeColor = SystemColors.Control;
                label6.ForeColor = SystemColors.Control;
                label7.ForeColor = SystemColors.Control;
                label8.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                label3.ForeColor = SystemColors.Control;
                label4.ForeColor = SystemColors.Control;
                label5.ForeColor = SystemColors.Control;
                label6.ForeColor = SystemColors.Control;
                label7.ForeColor = SystemColors.Control;
                label8.ForeColor = SystemColors.Control;
            }
        }
        public void getname(string name)
        {
            label1.Text = name;
            tiptext();
        }

        public void tiptext()
        {
            if(label1.Text == "Learn Basic Navigation")
            {
                label2.Text = "Clicking on a day brings up a detailed look at the events for that day.";
                label3.Text = "After clicking the 'Add Event' button, you'll be able to input the information for that event.";
                label4.Text = "Click the save button to save the event and the event will display after you close the event creation window.";
                label5.Text = "To Remove events, click the check box labeled 'Remove Events' and click on events to remove them.";
                label6.Text = "Clicking on the left and right arrows in the calendar screen moves the calendar backward and foreward a month respectively.";
                label7.Text = "The Settings menu is opened by clicking the 'Settings' button in the calendar screen.";
                label8.Text = "It contains a few settings that change the display. As well as a setting to turn off the Scheduling Tips in the calendar.";
            }
            else if(label1.Text == "Scheduling Downtime")
            {
                label2.Text = "Make sure to not overschedule and give yourself breaks.";
                label3.Text = "Overworking yourself can lead to increased stress, decreased work efficiency, lack of sleep, and other negative effects.";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
            else if( label1.Text == "Prioritizing Events")
            {
                label2.Text = "When assembling a schedule, a general rule of thumb is to schedule the most important things first.";
                label3.Text = "Events that you don't have the power to change the time and location of should be the events that are scheduled first.";
                label4.Text = "The rest of the schedule should be scheduled around these unchangeable events.";
                label5.Text = "An example of this would be a class or a business meeting, you have no control over when and where they happen.";
                label6.Text = "So, you should plan study time, social activities, and breaks around those events.";
                label7.Text = "";
                label8.Text = "";
            }
        }

        private void Tip_Close(object sender, EventArgs e)
        {
            O.displayDays();
        }

        private void TipView_Load(object sender, EventArgs e)
        {
            O.flowLayoutPanel2.Controls.Remove(c);
        }
    }
}
