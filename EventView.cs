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
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Menu;
                DateLb.ForeColor = SystemColors.ControlText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlText;
                DateLb.ForeColor = SystemColors.Control;
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
            UCModel uCModels = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
            UCModel uCModele = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
            if (Estarttime == 000)
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(uCModels);
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
                    flowLayoutPanel2.Controls.Add(uCModels);
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
                    flowLayoutPanel3.Controls.Add(uCModels);
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
                    flowLayoutPanel4.Controls.Add(uCModels);
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
                    flowLayoutPanel5.Controls.Add(uCModels);
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
                    flowLayoutPanel6.Controls.Add(uCModels);
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
                    flowLayoutPanel7.Controls.Add(uCModels);
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
                    flowLayoutPanel8.Controls.Add(uCModels);
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
                    flowLayoutPanel9.Controls.Add(uCModels);
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
                    flowLayoutPanel10.Controls.Add(uCModels);
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
                    flowLayoutPanel11.Controls.Add(uCModels);
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
                    flowLayoutPanel12.Controls.Add(uCModels);
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
                    flowLayoutPanel13.Controls.Add(uCModels);
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
                    flowLayoutPanel14.Controls.Add(uCModels);
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
                    flowLayoutPanel15.Controls.Add(uCModels);
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
                    flowLayoutPanel16.Controls.Add(uCModels);
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
                    flowLayoutPanel17.Controls.Add(uCModels);
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
                    flowLayoutPanel18.Controls.Add(uCModels);
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
                    flowLayoutPanel19.Controls.Add(uCModels);
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
                    flowLayoutPanel20.Controls.Add(uCModels);
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
                    flowLayoutPanel21.Controls.Add(uCModels);
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
                    flowLayoutPanel22.Controls.Add(uCModels);
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
                    flowLayoutPanel23.Controls.Add(uCModels);
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
                    flowLayoutPanel24.Controls.Add(uCModels);
                }
            }

            if ((Eendtime - Estarttime) != 0)
            {
                if (Eendtime == 000)
                {
                    if (flowLayoutPanel1.Controls.Count > 0)
                    {
                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(uCModele);
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
                        flowLayoutPanel2.Controls.Add(uCModele);
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
                        flowLayoutPanel3.Controls.Add(uCModele);
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
                        flowLayoutPanel4.Controls.Add(uCModele);
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
                        flowLayoutPanel5.Controls.Add(uCModele);
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
                        flowLayoutPanel6.Controls.Add(uCModele);
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
                        flowLayoutPanel7.Controls.Add(uCModele);
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
                        flowLayoutPanel8.Controls.Add(uCModele);
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
                        flowLayoutPanel9.Controls.Add(uCModele);
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
                        flowLayoutPanel10.Controls.Add(uCModele);
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
                        flowLayoutPanel11.Controls.Add(uCModele);
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
                        flowLayoutPanel12.Controls.Add(uCModele);
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
                        flowLayoutPanel13.Controls.Add(uCModele);
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
                        flowLayoutPanel14.Controls.Add(uCModele);
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
                        flowLayoutPanel15.Controls.Add(uCModele);
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
                        flowLayoutPanel16.Controls.Add(uCModele);
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
                        flowLayoutPanel17.Controls.Add(uCModele);
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
                        flowLayoutPanel18.Controls.Add(uCModele);
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
                        flowLayoutPanel19.Controls.Add(uCModele);
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
                        flowLayoutPanel20.Controls.Add(uCModele);
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
                        flowLayoutPanel21.Controls.Add(uCModele);
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
                        flowLayoutPanel22.Controls.Add(uCModele);
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
                        flowLayoutPanel23.Controls.Add(uCModele);
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
                        flowLayoutPanel24.Controls.Add(uCModele);
                    }
                }
            }
            //adds ucmodel to flowlayoutpanels in between start and end
            if (((Eendtime - Estarttime) != 0) || (Eendtime - Estarttime) != 100)
            {
                if(Estarttime == 000)
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
                else if(Estarttime == 100)
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
                else if(Estarttime == 200)
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
                else if (Estarttime == 300)
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
                else if (Estarttime == 400)
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
                else if (Estarttime == 500)
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
                else if (Estarttime == 600)
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
                else if (Estarttime == 700)
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
                else if (Estarttime == 800)
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
                else if (Estarttime == 900)
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
                else if (Estarttime == 1000)
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
                else if (Estarttime == 1100)
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
                else if (Estarttime == 1200)
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
                else if (Estarttime == 1300)
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
                else if (Estarttime == 1400)
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
                else if (Estarttime == 1500)
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
                else if (Estarttime == 1600)
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
                else if (Estarttime == 1700)
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
                else if (Estarttime == 1800)
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
                else if (Estarttime == 1900)
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
                else if (Estarttime == 2000)
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
                else if (Estarttime == 2100)
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
                if ((Eendtime - Estarttime) > 200)
                {
                    UCModel uCModel1 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                    if (Estarttime == 000)
                    {
                        if (flowLayoutPanel3.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel3.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 100)
                    {
                        if (flowLayoutPanel4.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel4.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 200)
                    {
                        if (flowLayoutPanel5.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel5.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 300)
                    {
                        if (flowLayoutPanel6.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel6.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 400)
                    {
                        if (flowLayoutPanel7.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel7.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 500)
                    {
                        if (flowLayoutPanel8.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel8.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 600)
                    {
                        if (flowLayoutPanel9.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel9.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 700)
                    {
                        if (flowLayoutPanel10.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel10.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 800)
                    {
                        if (flowLayoutPanel11.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel11.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 900)
                    {
                        if (flowLayoutPanel12.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel12.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1000)
                    {
                        if (flowLayoutPanel13.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel13.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1100)
                    {
                        if (flowLayoutPanel14.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel14.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1200)
                    {
                        if (flowLayoutPanel15.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel15.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1300)
                    {
                        if (flowLayoutPanel16.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel16.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1400)
                    {
                        if (flowLayoutPanel17.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel17.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1500)
                    {
                        if (flowLayoutPanel18.Controls.Count > 0)
                        {
                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            flowLayoutPanel18.Controls.Add(uCModel1);
                        }
                    }
                    else if (Estarttime == 1600)
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
                    else if (Estarttime == 1700)
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
                    else if (Estarttime == 1800)
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
                    else if (Estarttime == 1900)
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
                    else if (Estarttime == 2000)
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
                    if ((Eendtime - Estarttime) > 300)
                    {
                        UCModel uCModel2 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                        if (Estarttime == 000)
                        {
                            if (flowLayoutPanel4.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel4.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 100)
                        {
                            if (flowLayoutPanel5.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel5.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 200)
                        {
                            if (flowLayoutPanel6.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel6.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 300)
                        {
                            if (flowLayoutPanel7.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel7.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 400)
                        {
                            if (flowLayoutPanel8.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel8.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 500)
                        {
                            if (flowLayoutPanel9.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel9.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 600)
                        {
                            if (flowLayoutPanel10.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel10.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 700)
                        {
                            if (flowLayoutPanel11.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel11.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 800)
                        {
                            if (flowLayoutPanel12.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel12.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 900)
                        {
                            if (flowLayoutPanel13.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel13.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1000)
                        {
                            if (flowLayoutPanel14.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel14.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1100)
                        {
                            if (flowLayoutPanel15.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel15.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1200)
                        {
                            if (flowLayoutPanel16.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel16.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1300)
                        {
                            if (flowLayoutPanel17.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel17.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1400)
                        {
                            if (flowLayoutPanel18.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel18.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1500)
                        {
                            if (flowLayoutPanel19.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel19.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1600)
                        {
                            if (flowLayoutPanel20.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel20.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1700)
                        {
                            if (flowLayoutPanel21.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel21.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1800)
                        {
                            if (flowLayoutPanel22.Controls.Count > 0)
                            {
                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                flowLayoutPanel22.Controls.Add(uCModel2);
                            }
                        }
                        else if (Estarttime == 1900)
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
                        if ((Eendtime - Estarttime) > 400)
                        {
                            UCModel uCModel3 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                            if (Estarttime == 000)
                            {
                                if (flowLayoutPanel5.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel5.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 100)
                            {
                                if (flowLayoutPanel6.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel6.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 200)
                            {
                                if (flowLayoutPanel7.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel7.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 300)
                            {
                                if (flowLayoutPanel8.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel8.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 400)
                            {
                                if (flowLayoutPanel9.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel9.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 500)
                            {
                                if (flowLayoutPanel10.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel10.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 600)
                            {
                                if (flowLayoutPanel11.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel11.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 700)
                            {
                                if (flowLayoutPanel12.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel12.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 800)
                            {
                                if (flowLayoutPanel13.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel13.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 900)
                            {
                                if (flowLayoutPanel14.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel14.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1000)
                            {
                                if (flowLayoutPanel15.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel15.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1100)
                            {
                                if (flowLayoutPanel16.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel16.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1200)
                            {
                                if (flowLayoutPanel17.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel17.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1300)
                            {
                                if (flowLayoutPanel18.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel18.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1400)
                            {
                                if (flowLayoutPanel19.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel19.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1500)
                            {
                                if (flowLayoutPanel20.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel20.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1600)
                            {
                                if (flowLayoutPanel21.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel21.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1700)
                            {
                                if (flowLayoutPanel22.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel22.Controls.Add(uCModel3);
                                }
                            }
                            else if (Estarttime == 1800)
                            {
                                if (flowLayoutPanel23.Controls.Count > 0)
                                {
                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    flowLayoutPanel23.Controls.Add(uCModel3);
                                }
                            }
                            if ((Eendtime - Estarttime) > 500)
                            {
                                UCModel uCModel4 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                if (Estarttime == 000)
                                {
                                    if (flowLayoutPanel6.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel6.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 100)
                                {
                                    if (flowLayoutPanel7.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel7.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 200)
                                {
                                    if (flowLayoutPanel8.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel8.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 300)
                                {
                                    if (flowLayoutPanel9.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel9.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 400)
                                {
                                    if (flowLayoutPanel10.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel10.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 500)
                                {
                                    if (flowLayoutPanel11.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel11.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 600)
                                {
                                    if (flowLayoutPanel12.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel12.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 700)
                                {
                                    if (flowLayoutPanel13.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel13.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 800)
                                {
                                    if (flowLayoutPanel14.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel14.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 900)
                                {
                                    if (flowLayoutPanel15.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel15.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1000)
                                {
                                    if (flowLayoutPanel16.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel16.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1100)
                                {
                                    if (flowLayoutPanel17.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel17.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1200)
                                {
                                    if (flowLayoutPanel18.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel18.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1300)
                                {
                                    if (flowLayoutPanel19.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel19.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1400)
                                {
                                    if (flowLayoutPanel20.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel20.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1500)
                                {
                                    if (flowLayoutPanel21.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel21.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1600)
                                {
                                    if (flowLayoutPanel22.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel22.Controls.Add(uCModel4);
                                    }
                                }
                                else if (Estarttime == 1700)
                                {
                                    if (flowLayoutPanel23.Controls.Count > 0)
                                    {
                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        flowLayoutPanel23.Controls.Add(uCModel4);
                                    }
                                }
                                if ((Eendtime - Estarttime) > 600)
                                {
                                    UCModel uCModel5 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                    if (Estarttime == 000)
                                    {
                                        if (flowLayoutPanel7.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel7.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 100)
                                    {
                                        if (flowLayoutPanel8.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel8.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 200)
                                    {
                                        if (flowLayoutPanel9.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel9.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 300)
                                    {
                                        if (flowLayoutPanel10.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel10.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 400)
                                    {
                                        if (flowLayoutPanel11.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel11.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 500)
                                    {
                                        if (flowLayoutPanel12.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel12.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 600)
                                    {
                                        if (flowLayoutPanel13.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel13.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 700)
                                    {
                                        if (flowLayoutPanel14.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel14.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 800)
                                    {
                                        if (flowLayoutPanel15.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel15.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 900)
                                    {
                                        if (flowLayoutPanel16.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel16.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1000)
                                    {
                                        if (flowLayoutPanel17.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel17.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1100)
                                    {
                                        if (flowLayoutPanel18.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel18.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1200)
                                    {
                                        if (flowLayoutPanel19.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel19.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1300)
                                    {
                                        if (flowLayoutPanel20.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel20.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1400)
                                    {
                                        if (flowLayoutPanel21.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel21.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1500)
                                    {
                                        if (flowLayoutPanel22.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel22.Controls.Add(uCModel5);
                                        }
                                    }
                                    else if (Estarttime == 1600)
                                    {
                                        if (flowLayoutPanel23.Controls.Count > 0)
                                        {
                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            flowLayoutPanel23.Controls.Add(uCModel5);
                                        }
                                    }
                                    if ((Eendtime - Estarttime) > 700)
                                    {
                                        UCModel uCModel6 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                        if (Estarttime == 000)
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
                                        else if (Estarttime == 100)
                                        {
                                            if (flowLayoutPanel9.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel9.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 200)
                                        {
                                            if (flowLayoutPanel10.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel10.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 300)
                                        {
                                            if (flowLayoutPanel11.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel11.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 400)
                                        {
                                            if (flowLayoutPanel12.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel12.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 500)
                                        {
                                            if (flowLayoutPanel13.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel13.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 600)
                                        {
                                            if (flowLayoutPanel14.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel14.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 700)
                                        {
                                            if (flowLayoutPanel15.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel15.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 800)
                                        {
                                            if (flowLayoutPanel16.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel16.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 900)
                                        {
                                            if (flowLayoutPanel17.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel17.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1000)
                                        {
                                            if (flowLayoutPanel18.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel18.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1100)
                                        {
                                            if (flowLayoutPanel19.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel19.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1200)
                                        {
                                            if (flowLayoutPanel20.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel20.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1300)
                                        {
                                            if (flowLayoutPanel21.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel21.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1400)
                                        {
                                            if (flowLayoutPanel22.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel22.Controls.Add(uCModel6);
                                            }
                                        }
                                        else if (Estarttime == 1500)
                                        {
                                            if (flowLayoutPanel23.Controls.Count > 0)
                                            {
                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                flowLayoutPanel23.Controls.Add(uCModel6);
                                            }
                                        }
                                        if ((Eendtime - Estarttime) > 800)
                                        {
                                            UCModel uCModel7 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                            if (Estarttime == 000)
                                            {
                                                if (flowLayoutPanel9.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel9.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 100)
                                            {
                                                if (flowLayoutPanel10.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel10.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 200)
                                            {
                                                if (flowLayoutPanel11.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel11.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 300)
                                            {
                                                if (flowLayoutPanel12.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel12.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 400)
                                            {
                                                if (flowLayoutPanel13.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel13.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 500)
                                            {
                                                if (flowLayoutPanel14.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel14.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 600)
                                            {
                                                if (flowLayoutPanel15.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel15.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 700)
                                            {
                                                if (flowLayoutPanel16.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel16.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 800)
                                            {
                                                if (flowLayoutPanel17.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel17.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 900)
                                            {
                                                if (flowLayoutPanel18.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel18.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 1000)
                                            {
                                                if (flowLayoutPanel19.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel19.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 1100)
                                            {
                                                if (flowLayoutPanel20.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel20.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 1200)
                                            {
                                                if (flowLayoutPanel21.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel21.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 1300)
                                            {
                                                if (flowLayoutPanel22.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel22.Controls.Add(uCModel7);
                                                }
                                            }
                                            else if (Estarttime == 1400)
                                            {
                                                if (flowLayoutPanel23.Controls.Count > 0)
                                                {
                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    flowLayoutPanel23.Controls.Add(uCModel7);
                                                }
                                            }
                                            if ((Eendtime - Estarttime) > 900)
                                            {
                                                UCModel uCModel8 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                if (Estarttime == 000)
                                                {
                                                    if (flowLayoutPanel10.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel10.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 100)
                                                {
                                                    if (flowLayoutPanel11.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel11.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 200)
                                                {
                                                    if (flowLayoutPanel12.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel12.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 300)
                                                {
                                                    if (flowLayoutPanel13.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel13.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 400)
                                                {
                                                    if (flowLayoutPanel14.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel14.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 500)
                                                {
                                                    if (flowLayoutPanel15.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel15.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 600)
                                                {
                                                    if (flowLayoutPanel16.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel16.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 700)
                                                {
                                                    if (flowLayoutPanel17.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel17.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 800)
                                                {
                                                    if (flowLayoutPanel18.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel18.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 900)
                                                {
                                                    if (flowLayoutPanel19.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel19.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 1000)
                                                {
                                                    if (flowLayoutPanel20.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel20.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 1100)
                                                {
                                                    if (flowLayoutPanel21.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel21.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 1200)
                                                {
                                                    if (flowLayoutPanel22.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel22.Controls.Add(uCModel8);
                                                    }
                                                }
                                                else if (Estarttime == 1300)
                                                {
                                                    if (flowLayoutPanel23.Controls.Count > 0)
                                                    {
                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        flowLayoutPanel23.Controls.Add(uCModel8);
                                                    }
                                                }
                                                if ((Eendtime - Estarttime) > 1000)
                                                {
                                                    UCModel uCModel9 = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                    if (Estarttime == 000)
                                                    {
                                                        if (flowLayoutPanel11.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel11.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 100)
                                                    {
                                                        if (flowLayoutPanel12.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel12.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 200)
                                                    {
                                                        if (flowLayoutPanel13.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel13.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 300)
                                                    {
                                                        if (flowLayoutPanel14.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel14.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 400)
                                                    {
                                                        if (flowLayoutPanel15.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel15.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 500)
                                                    {
                                                        if (flowLayoutPanel16.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel16.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 600)
                                                    {
                                                        if (flowLayoutPanel17.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel17.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 700)
                                                    {
                                                        if (flowLayoutPanel18.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel18.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 800)
                                                    {
                                                        if (flowLayoutPanel19.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel19.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 900)
                                                    {
                                                        if (flowLayoutPanel20.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel20.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 1000)
                                                    {
                                                        if (flowLayoutPanel21.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel21.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 1100)
                                                    {
                                                        if (flowLayoutPanel22.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel22.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    else if (Estarttime == 1200)
                                                    {
                                                        if (flowLayoutPanel23.Controls.Count > 0)
                                                        {
                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                        {
                                                            flowLayoutPanel23.Controls.Add(uCModel9);
                                                        }
                                                    }
                                                    if ((Eendtime - Estarttime) > 1100)
                                                    {
                                                        UCModel uCModelA = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                        if (Estarttime == 000)
                                                        {
                                                            if (flowLayoutPanel12.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel12.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 100)
                                                        {
                                                            if (flowLayoutPanel13.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel13.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 200)
                                                        {
                                                            if (flowLayoutPanel14.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel14.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 300)
                                                        {
                                                            if (flowLayoutPanel15.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel15.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 400)
                                                        {
                                                            if (flowLayoutPanel16.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel16.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 500)
                                                        {
                                                            if (flowLayoutPanel17.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel17.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 600)
                                                        {
                                                            if (flowLayoutPanel18.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel18.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 700)
                                                        {
                                                            if (flowLayoutPanel19.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel19.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 800)
                                                        {
                                                            if (flowLayoutPanel20.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel20.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 900)
                                                        {
                                                            if (flowLayoutPanel21.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel21.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 1000)
                                                        {
                                                            if (flowLayoutPanel22.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel22.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        else if (Estarttime == 1100)
                                                        {
                                                            if (flowLayoutPanel23.Controls.Count > 0)
                                                            {
                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                flowLayoutPanel23.Controls.Add(uCModelA);
                                                            }
                                                        }
                                                        if ((Eendtime - Estarttime) > 1200)
                                                        {
                                                            UCModel uCModelB = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                            if (Estarttime == 000)
                                                            {
                                                                if (flowLayoutPanel13.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel13.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 100)
                                                            {
                                                                if (flowLayoutPanel14.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel14.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 200)
                                                            {
                                                                if (flowLayoutPanel15.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel15.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 300)
                                                            {
                                                                if (flowLayoutPanel16.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel16.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 400)
                                                            {
                                                                if (flowLayoutPanel17.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel17.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 500)
                                                            {
                                                                if (flowLayoutPanel18.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel18.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 600)
                                                            {
                                                                if (flowLayoutPanel19.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel19.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 700)
                                                            {
                                                                if (flowLayoutPanel20.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel20.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 800)
                                                            {
                                                                if (flowLayoutPanel21.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel21.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 900)
                                                            {
                                                                if (flowLayoutPanel22.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel22.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            else if (Estarttime == 1000)
                                                            {
                                                                if (flowLayoutPanel23.Controls.Count > 0)
                                                                {
                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {
                                                                    flowLayoutPanel23.Controls.Add(uCModelB);
                                                                }
                                                            }
                                                            if ((Eendtime - Estarttime) > 1300)
                                                            {
                                                                UCModel uCModelC = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                if (Estarttime == 000)
                                                                {
                                                                    if (flowLayoutPanel14.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel14.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 100)
                                                                {
                                                                    if (flowLayoutPanel15.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel15.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 200)
                                                                {
                                                                    if (flowLayoutPanel16.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel16.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 300)
                                                                {
                                                                    if (flowLayoutPanel17.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel17.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 400)
                                                                {
                                                                    if (flowLayoutPanel18.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel18.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 500)
                                                                {
                                                                    if (flowLayoutPanel19.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel19.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 600)
                                                                {
                                                                    if (flowLayoutPanel20.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel20.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 700)
                                                                {
                                                                    if (flowLayoutPanel21.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel21.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 800)
                                                                {
                                                                    if (flowLayoutPanel22.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel22.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                else if (Estarttime == 900)
                                                                {
                                                                    if (flowLayoutPanel23.Controls.Count > 0)
                                                                    {
                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    else
                                                                    {
                                                                        flowLayoutPanel23.Controls.Add(uCModelC);
                                                                    }
                                                                }
                                                                if ((Eendtime - Estarttime) > 1400)
                                                                {
                                                                    UCModel uCModelD = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                    if (Estarttime == 000)
                                                                    {
                                                                        if (flowLayoutPanel15.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel15.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 100)
                                                                    {
                                                                        if (flowLayoutPanel16.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel16.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 200)
                                                                    {
                                                                        if (flowLayoutPanel17.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel17.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 300)
                                                                    {
                                                                        if (flowLayoutPanel18.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel18.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 400)
                                                                    {
                                                                        if (flowLayoutPanel19.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel19.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 500)
                                                                    {
                                                                        if (flowLayoutPanel20.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel20.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 600)
                                                                    {
                                                                        if (flowLayoutPanel21.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel21.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 700)
                                                                    {
                                                                        if (flowLayoutPanel22.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel22.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    else if (Estarttime == 800)
                                                                    {
                                                                        if (flowLayoutPanel23.Controls.Count > 0)
                                                                        {
                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                        else
                                                                        {
                                                                            flowLayoutPanel23.Controls.Add(uCModelD);
                                                                        }
                                                                    }
                                                                    if ((Eendtime - Estarttime) > 1500)
                                                                    {
                                                                        UCModel uCModelE = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                        if (Estarttime == 000)
                                                                        {
                                                                            if (flowLayoutPanel16.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel16.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 100)
                                                                        {
                                                                            if (flowLayoutPanel17.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel17.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 200)
                                                                        {
                                                                            if (flowLayoutPanel18.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel18.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 300)
                                                                        {
                                                                            if (flowLayoutPanel19.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel19.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 400)
                                                                        {
                                                                            if (flowLayoutPanel20.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel20.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 500)
                                                                        {
                                                                            if (flowLayoutPanel21.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel21.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 600)
                                                                        {
                                                                            if (flowLayoutPanel22.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel22.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        else if (Estarttime == 700)
                                                                        {
                                                                            if (flowLayoutPanel23.Controls.Count > 0)
                                                                            {
                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            }
                                                                            else
                                                                            {
                                                                                flowLayoutPanel23.Controls.Add(uCModelE);
                                                                            }
                                                                        }
                                                                        if ((Eendtime - Estarttime) > 1600)
                                                                        {
                                                                            UCModel uCModelF = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                            if (Estarttime == 000)
                                                                            {
                                                                                if (flowLayoutPanel17.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel17.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 100)
                                                                            {
                                                                                if (flowLayoutPanel18.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel18.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 200)
                                                                            {
                                                                                if (flowLayoutPanel19.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel19.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 300)
                                                                            {
                                                                                if (flowLayoutPanel20.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel20.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 400)
                                                                            {
                                                                                if (flowLayoutPanel21.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel21.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 500)
                                                                            {
                                                                                if (flowLayoutPanel22.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel22.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            else if (Estarttime == 600)
                                                                            {
                                                                                if (flowLayoutPanel23.Controls.Count > 0)
                                                                                {
                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                                else
                                                                                {
                                                                                    flowLayoutPanel23.Controls.Add(uCModelF);
                                                                                }
                                                                            }
                                                                            if ((Eendtime - Estarttime) > 1700)
                                                                            {
                                                                                UCModel uCModelG = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                                if (Estarttime == 000)
                                                                                {
                                                                                    if (flowLayoutPanel18.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel18.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                else if (Estarttime == 100)
                                                                                {
                                                                                    if (flowLayoutPanel19.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel19.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                else if (Estarttime == 200)
                                                                                {
                                                                                    if (flowLayoutPanel20.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel20.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                else if (Estarttime == 300)
                                                                                {
                                                                                    if (flowLayoutPanel21.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel21.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                else if (Estarttime == 400)
                                                                                {
                                                                                    if (flowLayoutPanel22.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel22.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                else if (Estarttime == 500)
                                                                                {
                                                                                    if (flowLayoutPanel23.Controls.Count > 0)
                                                                                    {
                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flowLayoutPanel23.Controls.Add(uCModelG);
                                                                                    }
                                                                                }
                                                                                if ((Eendtime - Estarttime) > 1800)
                                                                                {
                                                                                    UCModel uCModelH = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                                    if (Estarttime == 000)
                                                                                    {
                                                                                        if (flowLayoutPanel19.Controls.Count > 0)
                                                                                        {
                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flowLayoutPanel19.Controls.Add(uCModelH);
                                                                                        }
                                                                                    }
                                                                                    else if (Estarttime == 100)
                                                                                    {
                                                                                        if (flowLayoutPanel20.Controls.Count > 0)
                                                                                        {
                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flowLayoutPanel20.Controls.Add(uCModelH);
                                                                                        }
                                                                                    }
                                                                                    else if (Estarttime == 200)
                                                                                    {
                                                                                        if (flowLayoutPanel21.Controls.Count > 0)
                                                                                        {
                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flowLayoutPanel21.Controls.Add(uCModelH);
                                                                                        }
                                                                                    }
                                                                                    else if (Estarttime == 300)
                                                                                    {
                                                                                        if (flowLayoutPanel22.Controls.Count > 0)
                                                                                        {
                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flowLayoutPanel22.Controls.Add(uCModelH);
                                                                                        }
                                                                                    }
                                                                                    else if (Estarttime == 400)
                                                                                    {
                                                                                        if (flowLayoutPanel23.Controls.Count > 0)
                                                                                        {
                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flowLayoutPanel23.Controls.Add(uCModelH);
                                                                                        }
                                                                                    }
                                                                                    if ((Eendtime - Estarttime) > 1900)
                                                                                    {
                                                                                        UCModel uCModelI = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                                        if (Estarttime == 000)
                                                                                        {
                                                                                            if (flowLayoutPanel20.Controls.Count > 0)
                                                                                            {
                                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flowLayoutPanel20.Controls.Add(uCModelI);
                                                                                            }
                                                                                        }
                                                                                        else if (Estarttime == 100)
                                                                                        {
                                                                                            if (flowLayoutPanel21.Controls.Count > 0)
                                                                                            {
                                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flowLayoutPanel21.Controls.Add(uCModelI);
                                                                                            }
                                                                                        }
                                                                                        else if (Estarttime == 200)
                                                                                        {
                                                                                            if (flowLayoutPanel22.Controls.Count > 0)
                                                                                            {
                                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flowLayoutPanel22.Controls.Add(uCModelI);
                                                                                            }
                                                                                        }
                                                                                        else if (Estarttime == 300)
                                                                                        {
                                                                                            if (flowLayoutPanel23.Controls.Count > 0)
                                                                                            {
                                                                                                MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flowLayoutPanel23.Controls.Add(uCModelI);
                                                                                            }
                                                                                        }
                                                                                        if ((Eendtime - Estarttime) > 2000)
                                                                                        {
                                                                                            UCModel uCModelJ = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                                            if (Estarttime == 000)
                                                                                            {
                                                                                                if (flowLayoutPanel21.Controls.Count > 0)
                                                                                                {
                                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    flowLayoutPanel21.Controls.Add(uCModelJ);
                                                                                                }
                                                                                            }
                                                                                            else if (Estarttime == 100)
                                                                                            {
                                                                                                if (flowLayoutPanel22.Controls.Count > 0)
                                                                                                {
                                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    flowLayoutPanel22.Controls.Add(uCModelJ);
                                                                                                }
                                                                                            }
                                                                                            else if (Estarttime == 200)
                                                                                            {
                                                                                                if (flowLayoutPanel23.Controls.Count > 0)
                                                                                                {
                                                                                                    MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    flowLayoutPanel23.Controls.Add(uCModelJ);
                                                                                                }
                                                                                            }
                                                                                            if ((Eendtime - Estarttime) > 2100)
                                                                                            {
                                                                                                UCModel uCModelK = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);
                                                                                                if (Estarttime == 000)
                                                                                                {
                                                                                                    if (flowLayoutPanel22.Controls.Count > 0)
                                                                                                    {
                                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        flowLayoutPanel22.Controls.Add(uCModelK);
                                                                                                    }
                                                                                                }
                                                                                                else if (Estarttime == 100)
                                                                                                {
                                                                                                    if (flowLayoutPanel23.Controls.Count > 0)
                                                                                                    {
                                                                                                        MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        flowLayoutPanel23.Controls.Add(uCModelK);
                                                                                                    }
                                                                                                }
                                                                                                if ((Eendtime - Estarttime) > 2200)
                                                                                                {
                                                                                                    UCModel uCModelL = new UCModel(Ename, Elocation, Ecategory, Estarttime, Eendtime, repeatability, reminders);                                                                                                    if (Estarttime == 100)
                                                                                                    {
                                                                                                        if (flowLayoutPanel23.Controls.Count > 0)
                                                                                                        {
                                                                                                            MessageBox.Show("Two events cannot overlap. Please re-Schedule.", "Error: Overlapping Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            flowLayoutPanel23.Controls.Add(uCModelL);
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Add something to Remove Event
        }
    }
}
