using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //If statement to change display order based on setting in settings menue
            DateLb.Text = CurrentMonth + "  " + CurrentDay + "  " + CurrentYear;
            //ToDo: EventView UI (You can use the "Toolbox" menue in "EventView.cs [Design]" to add UI elements)
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
