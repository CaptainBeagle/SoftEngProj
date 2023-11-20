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

        private void button1_Click(object sender, EventArgs e)
        {
            AddEventInput AEI = new AddEventInput();
            AEI.Show();
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
                //Why won't this display?
            }
        }

        public static FlowLayoutPanel GetFlowLayoutPanel(int flp)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Size = new Size(1200, 260);
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            if(flp == 1)
            {
                flowLayoutPanel.Location = new Point(167, 141);
                flowLayoutPanel.TabIndex = 34;
            }
            else if(flp == 2)
            {
                flowLayoutPanel.Location = new Point(167, 404);
                flowLayoutPanel.TabIndex = 35;
            }
            else if(flp == 3)
            {
                flowLayoutPanel.Location = new Point(167, 670);
                flowLayoutPanel.TabIndex = 36;
            }
            else if (flp == 4)
            {
                flowLayoutPanel.Location = new Point(167, 936);
                flowLayoutPanel.TabIndex = 37;
            }
            else if (flp == 5)
            {
                flowLayoutPanel.Location = new Point(167, 1195);
                flowLayoutPanel.TabIndex = 38;
            }
            else if (flp == 6)
            {
                flowLayoutPanel.Location = new Point(167, 1461);
                flowLayoutPanel.TabIndex = 39;
            }
            else if (flp == 7)
            {
                flowLayoutPanel.Location = new Point(167, 1727);
                flowLayoutPanel.TabIndex = 40;
            }
            else if (flp == 8)
            {
                flowLayoutPanel.Location = new Point(167, 1993);
                flowLayoutPanel.TabIndex = 41;
            }
            else if (flp == 9)
            {
                flowLayoutPanel.Location = new Point(167, 2259);
            }
            else if (flp == 10)
            {
                flowLayoutPanel.Location = new Point(167, 2525);
            }
            else if (flp == 11)
            {
                flowLayoutPanel.Location = new Point(167, 2791);
            }
            else if (flp == 12)
            {
                flowLayoutPanel.Location = new Point(167, 3057);
            }
            else if (flp == 13)
            {
                flowLayoutPanel.Location = new Point(167, 3323);
            }
            else if (flp == 14)
            {
                flowLayoutPanel.Location = new Point(167, 3589);
            }
            else if (flp == 15)
            {
                flowLayoutPanel.Location = new Point(167, 3855);
            }
            else if (flp == 16)
            {
                flowLayoutPanel.Location = new Point(167, 4120);
            }
            else if (flp == 17)
            {
                flowLayoutPanel.Location = new Point(167, 4387);
            }
            else if (flp == 18)
            {
                flowLayoutPanel.Location = new Point(167, 4653);
            }
            else if (flp == 19)
            {
                flowLayoutPanel.Location = new Point(167, 4919);
            }
            else if (flp == 20)
            {
                flowLayoutPanel.Location = new Point(167, 5185);
            }
            else if (flp == 21)
            {
                flowLayoutPanel.Location = new Point(167, 5451);
            }
            else if (flp == 22)
            {
                flowLayoutPanel.Location = new Point(167, 5717);
            }
            else if (flp == 23)
            {
                flowLayoutPanel.Location = new Point(167, 5983);
            }
            else if (flp == 24)
            {
                flowLayoutPanel.Location = new Point(167, 6249);
            }
            return flowLayoutPanel;
        }

        public static void AddEvent(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            //Call this method when "save" button is clicked to add the inputed info to the Model
            UCModel uCModel = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
            if (Estarttime == 000)
            {
                GetFlowLayoutPanel(1).Controls.Add(uCModel);
            }
            else if (Estarttime == 100)
            {
                GetFlowLayoutPanel(2).Controls.Add(uCModel);
            }
            else if (Estarttime == 200)
            {
                GetFlowLayoutPanel(3).Controls.Add(uCModel);
            }
            else if (Estarttime == 300)
            {
                GetFlowLayoutPanel(4).Controls.Add(uCModel);
            }
            else if (Estarttime == 400)
            {
                GetFlowLayoutPanel(5).Controls.Add(uCModel);
            }
            else if (Estarttime == 500)
            {
                GetFlowLayoutPanel(6).Controls.Add(uCModel);
            }
            else if (Estarttime == 600)
            {
                GetFlowLayoutPanel(7).Controls.Add(uCModel);
            }
            else if (Estarttime == 700)
            {
                GetFlowLayoutPanel(8).Controls.Add(uCModel);
            }
            else if (Estarttime == 800)
            {
                GetFlowLayoutPanel(9).Controls.Add(uCModel);
            }
            else if (Estarttime == 900)
            {
                GetFlowLayoutPanel(10).Controls.Add(uCModel);
            }
            else if (Estarttime == 1000)
            {
                GetFlowLayoutPanel(11).Controls.Add(uCModel);
            }
            else if (Estarttime == 1100)
            {
                GetFlowLayoutPanel(12).Controls.Add(uCModel);
            }
            else if (Estarttime == 1200)
            {
                GetFlowLayoutPanel(13).Controls.Add(uCModel);
            }
            else if (Estarttime == 1300)
            {
                GetFlowLayoutPanel(14).Controls.Add(uCModel);
            }
            else if (Estarttime == 1400)
            {
                GetFlowLayoutPanel(15).Controls.Add(uCModel);
            }
            else if (Estarttime == 1500)
            {
                GetFlowLayoutPanel(16).Controls.Add(uCModel);
            }
            else if (Estarttime == 1600)
            {
                GetFlowLayoutPanel(17).Controls.Add(uCModel);
            }
            else if (Estarttime == 1700)
            {
                GetFlowLayoutPanel(18).Controls.Add(uCModel);
            }
            else if (Estarttime == 1800)
            {
                GetFlowLayoutPanel(19).Controls.Add(uCModel);
            }
            else if (Estarttime == 1900)
            {
                GetFlowLayoutPanel(20).Controls.Add(uCModel);
            }
            else if (Estarttime == 2000)
            {
                GetFlowLayoutPanel(21).Controls.Add(uCModel);
            }
            else if (Estarttime == 2100)
            {
                GetFlowLayoutPanel(22).Controls.Add(uCModel);
            }
            else if (Estarttime == 2200)
            {
                GetFlowLayoutPanel(23).Controls.Add(uCModel);
            }
            else if (Estarttime == 2300)
            {
                GetFlowLayoutPanel(24).Controls.Add(uCModel);
            }
        }
    }
}
