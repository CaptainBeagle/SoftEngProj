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
            AEI.Owner = this;
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
        }

        public void AddEvent(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            //Call this method when "save" button is clicked to add the inputed info to the Model
            UCModel uCModel = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
            if (Estarttime == 000)
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 100)
            {
                if (flowLayoutPanel2.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 200)
            {
                if (flowLayoutPanel3.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel3.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 300)
            {
                if (flowLayoutPanel4.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel4.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 400)
            {
                if (flowLayoutPanel5.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel5.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 500)
            {
                if (flowLayoutPanel6.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel6.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 600)
            {
                if (flowLayoutPanel7.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel7.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 700)
            {
                if (flowLayoutPanel8.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel8.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 800)
            {
                if (flowLayoutPanel9.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel9.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 900)
            {
                if (flowLayoutPanel10.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel10.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1000)
            {
                if (flowLayoutPanel11.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel11.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1100)
            {
                if (flowLayoutPanel12.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel12.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1200)
            {
                if (flowLayoutPanel13.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel13.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1300)
            {
                if (flowLayoutPanel14.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel14.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1400)
            {
                if (flowLayoutPanel15.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel15.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1500)
            {
                if (flowLayoutPanel16.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel16.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1600)
            {
                if (flowLayoutPanel17.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel17.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1700)
            {
                if (flowLayoutPanel18.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel18.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1800)
            {
                if (flowLayoutPanel19.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel19.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 1900)
            {
                if (flowLayoutPanel20.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel20.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 2000)
            {
                if (flowLayoutPanel21.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel21.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 2100)
            {
                if (flowLayoutPanel22.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel22.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 2200)
            {
                if (flowLayoutPanel23.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel23.Controls.Add(uCModel);
                }
            }
            else if (Estarttime == 2300)
            {
                if (flowLayoutPanel24.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel24.Controls.Add(uCModel);
                }
            }

            if (Eendtime == 000)
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 100)
            {
                if (flowLayoutPanel2.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel2.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 200)
            {
                if (flowLayoutPanel3.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel3.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 300)
            {
                if (flowLayoutPanel4.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel4.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 400)
            {
                if (flowLayoutPanel5.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel5.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 500)
            {
                if (flowLayoutPanel6.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel6.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 600)
            {
                if (flowLayoutPanel7.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel7.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 700)
            {
                if (flowLayoutPanel8.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel8.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 800)
            {
                if (flowLayoutPanel9.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel9.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 900)
            {
                if (flowLayoutPanel10.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel10.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1000)
            {
                if (flowLayoutPanel11.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel11.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1100)
            {
                if (flowLayoutPanel12.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel12.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1200)
            {
                if (flowLayoutPanel13.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel13.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1300)
            {
                if (flowLayoutPanel14.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel14.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1400)
            {
                if (flowLayoutPanel15.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel15.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1500)
            {
                if (flowLayoutPanel16.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel16.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1600)
            {
                if (flowLayoutPanel17.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel17.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1700)
            {
                if (flowLayoutPanel18.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel18.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1800)
            {
                if (flowLayoutPanel19.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel19.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 1900)
            {
                if (flowLayoutPanel20.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel20.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 2000)
            {
                if (flowLayoutPanel21.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel21.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 2100)
            {
                if (flowLayoutPanel22.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel22.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 2200)
            {
                if (flowLayoutPanel23.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel23.Controls.Add(uCModel);
                }
            }
            else if (Eendtime == 2300)
            {
                if (flowLayoutPanel24.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel24.Controls.Add(uCModel);
                }
            }
            //add ucmodel to flowlayoutpanels in between start and end
        }
    }
}
