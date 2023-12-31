﻿using System;
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
        private const int V = 1;
        public static string CurrentMonth, CurrentYear, CurrentDay;
        public UserControlDays Owned {  get; set; }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                ComponentModel.removeevent = true;
            }
            else
            {
                ComponentModel.removeevent = false;
            }
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            //if statement to change display theme based on setting in settings menu
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Menu;
                DateLb.ForeColor = SystemColors.ControlText;
                checkBox1.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                label3.ForeColor = SystemColors.ControlText;
                label4.ForeColor = SystemColors.ControlText;
                label5.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label8.ForeColor = SystemColors.ControlText;
                label9.ForeColor = SystemColors.ControlText;
                label10.ForeColor = SystemColors.ControlText;
                label11.ForeColor = SystemColors.ControlText;
                label12.ForeColor = SystemColors.ControlText;
                label13.ForeColor = SystemColors.ControlText;
                label14.ForeColor = SystemColors.ControlText;
                label15.ForeColor = SystemColors.ControlText;
                label16.ForeColor = SystemColors.ControlText;
                label17.ForeColor = SystemColors.ControlText;
                label18.ForeColor = SystemColors.ControlText;
                label20.ForeColor = SystemColors.ControlText;
                label21.ForeColor = SystemColors.ControlText;
                label22.ForeColor = SystemColors.ControlText;
                label23.ForeColor = SystemColors.ControlText;
                label24.ForeColor = SystemColors.ControlText;
                label25.ForeColor = SystemColors.ControlText;
            }
            else if (ComponentModel.savetheme == V)
            {
                this.BackColor = SystemColors.ControlText;
                DateLb.ForeColor = SystemColors.Control;
                checkBox1.ForeColor = SystemColors.Control;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                label3.ForeColor = SystemColors.Control;
                label4.ForeColor = SystemColors.Control;
                label5.ForeColor = SystemColors.Control;
                label6.ForeColor = SystemColors.Control;
                label7.ForeColor = SystemColors.Control;
                label8.ForeColor = SystemColors.Control;
                label9.ForeColor = SystemColors.Control;
                label10.ForeColor = SystemColors.Control;
                label11.ForeColor = SystemColors.Control;
                label12.ForeColor = SystemColors.Control;
                label13.ForeColor = SystemColors.Control;
                label14.ForeColor = SystemColors.Control;
                label15.ForeColor = SystemColors.Control;
                label16.ForeColor = SystemColors.Control;
                label17.ForeColor = SystemColors.Control;
                label18.ForeColor = SystemColors.Control;
                label20.ForeColor = SystemColors.Control;
                label21.ForeColor = SystemColors.Control;
                label22.ForeColor = SystemColors.Control;
                label23.ForeColor = SystemColors.Control;
                label24.ForeColor = SystemColors.Control;
                label25.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientInactiveCaption;
                DateLb.ForeColor = SystemColors.ControlText;
                checkBox1.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                label3.ForeColor = SystemColors.ControlText;
                label4.ForeColor = SystemColors.ControlText;
                label5.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label8.ForeColor = SystemColors.ControlText;
                label9.ForeColor = SystemColors.ControlText;
                label10.ForeColor = SystemColors.ControlText;
                label11.ForeColor = SystemColors.ControlText;
                label12.ForeColor = SystemColors.ControlText;
                label13.ForeColor = SystemColors.ControlText;
                label14.ForeColor = SystemColors.ControlText;
                label15.ForeColor = SystemColors.ControlText;
                label16.ForeColor = SystemColors.ControlText;
                label17.ForeColor = SystemColors.ControlText;
                label18.ForeColor = SystemColors.ControlText;
                label20.ForeColor = SystemColors.ControlText;
                label21.ForeColor = SystemColors.ControlText;
                label22.ForeColor = SystemColors.ControlText;
                label23.ForeColor = SystemColors.ControlText;
                label24.ForeColor = SystemColors.ControlText;
                label25.ForeColor = SystemColors.ControlText;
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
                if (flowLayoutPanel1.Controls.Count > V)
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
                if (flowLayoutPanel2.Controls.Count > V)
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
                if (flowLayoutPanel3.Controls.Count > V)
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
                if (flowLayoutPanel4.Controls.Count > V)
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
                if (flowLayoutPanel5.Controls.Count > V)
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
                if (flowLayoutPanel6.Controls.Count > V)
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
                if (flowLayoutPanel7.Controls.Count > V)
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
                if (flowLayoutPanel8.Controls.Count > V)
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
                if (flowLayoutPanel9.Controls.Count > V)
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
                if (flowLayoutPanel10.Controls.Count > V)
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
                if (flowLayoutPanel11.Controls.Count > V)
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
                if (flowLayoutPanel12.Controls.Count > V)
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
                if (flowLayoutPanel13.Controls.Count > V)
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
                if (flowLayoutPanel14.Controls.Count > V)
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
                if (flowLayoutPanel15.Controls.Count > V)
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
                if (flowLayoutPanel16.Controls.Count > V)
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
                if (flowLayoutPanel17.Controls.Count > V)
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
                if (flowLayoutPanel18.Controls.Count > V)
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
                if (flowLayoutPanel19.Controls.Count > V)
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
                if (flowLayoutPanel20.Controls.Count > V)
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
                if (flowLayoutPanel21.Controls.Count > V)
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
                if (flowLayoutPanel22.Controls.Count > V)
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
                if (flowLayoutPanel23.Controls.Count > V)
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
                if (flowLayoutPanel24.Controls.Count > V)
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
                    if (flowLayoutPanel1.Controls.Count > V)
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
                    if (flowLayoutPanel2.Controls.Count > V)
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
                    if (flowLayoutPanel3.Controls.Count > V)
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
                    if (flowLayoutPanel4.Controls.Count > V)
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
                    if (flowLayoutPanel5.Controls.Count > V)
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
                    if (flowLayoutPanel6.Controls.Count > V)
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
                    if (flowLayoutPanel7.Controls.Count > V)
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
                    if (flowLayoutPanel8.Controls.Count > V)
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
                    if (flowLayoutPanel9.Controls.Count > V)
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
                    if (flowLayoutPanel10.Controls.Count > V)
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
                    if (flowLayoutPanel11.Controls.Count > V)
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
                    if (flowLayoutPanel12.Controls.Count > V)
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
                    if (flowLayoutPanel13.Controls.Count > V)
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
                    if (flowLayoutPanel14.Controls.Count > V)
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
                    if (flowLayoutPanel15.Controls.Count > V)
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
                    if (flowLayoutPanel16.Controls.Count > V)
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
                    if (flowLayoutPanel2.Controls.Count > V)
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
                    if (flowLayoutPanel3.Controls.Count > V)
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
                    if (flowLayoutPanel4.Controls.Count > V)
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
                    if (flowLayoutPanel5.Controls.Count > V)
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
                    if (flowLayoutPanel6.Controls.Count > V)
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
                    if (flowLayoutPanel7.Controls.Count > V)
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
                    if (flowLayoutPanel8.Controls.Count > V)
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
                    if (flowLayoutPanel9.Controls.Count > V)
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
                    if (flowLayoutPanel10.Controls.Count > V)
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
                    if (flowLayoutPanel11.Controls.Count > V)
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
                    if (flowLayoutPanel12.Controls.Count > V)
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
                    if (flowLayoutPanel13.Controls.Count > V)
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
                    if (flowLayoutPanel14.Controls.Count > V)
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
                    if (flowLayoutPanel15.Controls.Count > V)
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
                    if (flowLayoutPanel16.Controls.Count > V)
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
                    if (flowLayoutPanel17.Controls.Count > V)
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
                    if (flowLayoutPanel18.Controls.Count > V)
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
                    if (flowLayoutPanel19.Controls.Count > V)
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
                    if (flowLayoutPanel20.Controls.Count > V)
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
                    if (flowLayoutPanel21.Controls.Count > V)
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
                    if (flowLayoutPanel22.Controls.Count > V)
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
                    if (flowLayoutPanel23.Controls.Count > V)
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
                    uCModel1.Ownedby = this;
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
                        uCModel2.Ownedby = this;
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
                            uCModel3.Ownedby = this;
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
                                uCModel4.Ownedby = this;
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
                                    uCModel5.Ownedby = this;
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
                                        uCModel6.Ownedby = this;
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
                                            uCModel7.Ownedby = this;
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
                                                uCModel8.Ownedby = this;
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
                                                    uCModel9.Ownedby = this;
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
                                                        uCModelA.Ownedby = this;
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
                                                            uCModelB.Ownedby = this;
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
                                                                uCModelC.Ownedby = this;
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
                                                                    uCModelD.Ownedby = this;
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
                                                                        uCModelE.Ownedby = this;
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
                                                                            uCModelF.Ownedby = this;
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
                                                                                uCModelG.Ownedby = this;
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
                                                                                    uCModelH.Ownedby = this;
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
                                                                                        uCModelI.Ownedby = this;
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
                                                                                            uCModelJ.Ownedby = this;
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
                                                                                                uCModelK.Ownedby = this;
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
            uCModel.Ownedby = this;
            uCModele.Ownedby = this;
            uCModels.Ownedby = this;
            foreach (UCModel uC in flowLayoutPanel1.Controls)
            {
                uC.Flp = flowLayoutPanel1;
            }
            foreach (UCModel uC in flowLayoutPanel2.Controls)
            {
                uC.Flp = flowLayoutPanel2;
            }
            foreach (UCModel uC in flowLayoutPanel3.Controls)
            {
                uC.Flp = flowLayoutPanel3;
            }
            foreach (UCModel uC in flowLayoutPanel4.Controls)
            {
                uC.Flp = flowLayoutPanel4;
            }
            foreach (UCModel uC in flowLayoutPanel5.Controls)
            {
                uC.Flp = flowLayoutPanel5;
            }
            foreach (UCModel uC in flowLayoutPanel6.Controls)
            {
                uC.Flp = flowLayoutPanel6;
            }
            foreach (UCModel uC in flowLayoutPanel7.Controls)
            {
                uC.Flp = flowLayoutPanel7;
            }
            foreach (UCModel uC in flowLayoutPanel8.Controls)
            {
                uC.Flp = flowLayoutPanel8;
            }
            foreach (UCModel uC in flowLayoutPanel9.Controls)
            {
                uC.Flp = flowLayoutPanel9;
            }
            foreach (UCModel uC in flowLayoutPanel10.Controls)
            {
                uC.Flp = flowLayoutPanel10;
            }
            foreach (UCModel uC in flowLayoutPanel11.Controls)
            {
                uC.Flp = flowLayoutPanel11;
            }
            foreach (UCModel uC in flowLayoutPanel12.Controls)
            {
                uC.Flp = flowLayoutPanel12;
            }
            foreach (UCModel uC in flowLayoutPanel13.Controls)
            {
                uC.Flp = flowLayoutPanel13;
            }
            foreach (UCModel uC in flowLayoutPanel14.Controls)
            {
                uC.Flp = flowLayoutPanel14;
            }
            foreach (UCModel uC in flowLayoutPanel15.Controls)
            {
                uC.Flp = flowLayoutPanel15;
            }
            foreach (UCModel uC in flowLayoutPanel16.Controls)
            {
                uC.Flp = flowLayoutPanel16;
            }
            foreach (UCModel uC in flowLayoutPanel17.Controls)
            {
                uC.Flp = flowLayoutPanel17;
            }
            foreach (UCModel uC in flowLayoutPanel18.Controls)
            {
                uC.Flp = flowLayoutPanel18;
            }
            foreach (UCModel uC in flowLayoutPanel19.Controls)
            {
                uC.Flp = flowLayoutPanel19;
            }
            foreach (UCModel uC in flowLayoutPanel20.Controls)
            {
                uC.Flp = flowLayoutPanel20;
            }
            foreach (UCModel uC in flowLayoutPanel21.Controls)
            {
                uC.Flp = flowLayoutPanel21;
            }
            foreach (UCModel uC in flowLayoutPanel22.Controls)
            {
                uC.Flp = flowLayoutPanel22;
            }
            foreach (UCModel uC in flowLayoutPanel23.Controls)
            {
                uC.Flp = flowLayoutPanel23;
            }
            foreach (UCModel uC in flowLayoutPanel24.Controls)
            {
                uC.Flp = flowLayoutPanel24;
            }
        }
        public void RemoveEvent(UCModel U, FlowLayoutPanel F)
        {
            F.Controls.Remove(U);
            F.Controls.Clear();
            ComponentModel.Rep = null;
        }

        private void EventView_FormClosed(object sender, EventArgs e)
        {
            //I can't do this anymore. Couldn't install packages for notifications and get them to work. I quit. I never want to have to do this again.
            //A small part of me wants to give up on a functioning adult life altogether. The prospect of being a shut-in sounds more appealing each minute I spend here.
        }
    }
}
