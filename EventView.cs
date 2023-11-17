using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftEngProj
{
    public partial class EventView : Form
    {
        public static string CurrentMonth, CurrentYear, CurrentDay;
        public EventView()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventView_Load(object sender, EventArgs e)
        {
            //if statement to change display theme based on setting in settings menu
            if (View.theme == 0)
            {
                this.BackColor = SystemColors.Menu;
                DateLb.ForeColor = SystemColors.ControlText;
            }
            else if (View.theme == 1)
            {
                this.BackColor = SystemColors.ControlText;
                DateLb.ForeColor = SystemColors.Control;
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
            //If statement to change display order based on setting in settings menu
            if(ComponentModel.dateorder == true)
            {
                DateLb.Text = CurrentDay + " " + CurrentMonth + " " + CurrentYear;
            }
            else
            {
                DateLb.Text = CurrentMonth + "  " + CurrentDay + "  " + CurrentYear;
            }
            //ToDo: EventView UI (You can use the "Toolbox" menue in "EventView.cs [Design]" to add UI elements)
            //  Create add/edit menu and connect to AddEvent function
            //  If more than one event, cancel action and make user change starttime
            //ToDo: Event creation and display
            if (CurrentDay == "16")
            {
                AddEvent("TestEvent", "Route66", "A test", 800, 1000, "False", "False"); //Tests the display of the event
            }
        }

        public void AddEvent(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            //Call this method when "save" button is clicked to add the inputed info to the Model
            UCModel uCModel = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
            if (Estarttime == 000)
            {
                flowLayoutPanel1.Controls.Add(uCModel);
            }
            else if (Estarttime == 100)
            {
                flowLayoutPanel2.Controls.Add(uCModel);
            }
            else if (Estarttime == 200)
            {
                flowLayoutPanel3.Controls.Add(uCModel);
            }
            else if (Estarttime == 300)
            {
                flowLayoutPanel4.Controls.Add(uCModel);
            }
            else if (Estarttime == 400)
            {
                flowLayoutPanel5.Controls.Add(uCModel);
            }
            else if (Estarttime == 500)
            {
                flowLayoutPanel6.Controls.Add(uCModel);
            }
            else if (Estarttime == 600)
            {
                flowLayoutPanel7.Controls.Add(uCModel);
            }
            else if (Estarttime == 700)
            {
                flowLayoutPanel8.Controls.Add(uCModel);
            }
            else if (Estarttime == 800)
            {
                flowLayoutPanel9.Controls.Add(uCModel);
            }
            else if (Estarttime == 900)
            {
                flowLayoutPanel10.Controls.Add(uCModel);
            }
            else if (Estarttime == 1000)
            {
                flowLayoutPanel11.Controls.Add(uCModel);
            }
            else if (Estarttime == 1100)
            {
                flowLayoutPanel12.Controls.Add(uCModel);
            }
            else if (Estarttime == 1200)
            {
                flowLayoutPanel13.Controls.Add(uCModel);
            }
            else if (Estarttime == 1300)
            {
                flowLayoutPanel14.Controls.Add(uCModel);
            }
            else if (Estarttime == 1400)
            {
                flowLayoutPanel15.Controls.Add(uCModel);
            }
            else if (Estarttime == 1500)
            {
                flowLayoutPanel16.Controls.Add(uCModel);
            }
            else if (Estarttime == 1600)
            {
                flowLayoutPanel17.Controls.Add(uCModel);
            }
            else if (Estarttime == 1700)
            {
                flowLayoutPanel18.Controls.Add(uCModel);
            }
            else if (Estarttime == 1800)
            {
                flowLayoutPanel19.Controls.Add(uCModel);
            }
            else if (Estarttime == 1900)
            {
                flowLayoutPanel20.Controls.Add(uCModel);
            }
            else if (Estarttime == 2000)
            {
                flowLayoutPanel21.Controls.Add(uCModel);
            }
            else if (Estarttime == 2100)
            {
                flowLayoutPanel22.Controls.Add(uCModel);
            }
            else if (Estarttime == 2200)
            {
                flowLayoutPanel23.Controls.Add(uCModel);
            }
            else if (Estarttime == 2300)
            {
                flowLayoutPanel24.Controls.Add(uCModel);
            }
            else if (Estarttime == 2400)
            {
                flowLayoutPanel25.Controls.Add(uCModel);
            }
        }
    }
}
