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
            //  Add labels for each hour
            //  Add flowlayout pannels with 30 min increment width
            //  Create add/edit menu and connect to AddEvent function
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
            this.Controls.Add(uCModel); //I may add flowlayoutpannel to organize it (And to put it in the right time slot)
        }
    }
}
