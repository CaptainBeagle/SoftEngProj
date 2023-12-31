﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftEngProj
{
    public partial class UCModel : UserControl
    {
        public EventView Ownedby { get; set; }
        public FlowLayoutPanel Flp {  get; set; }
        public UCModel(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            InitializeComponent();
            Namelb.Text = Ename;
            Catlb.Text = Ecategory;
            Locationlb.Text = Elocation;
            //Repeatability and reminders are set based on user input/drop down box and used to determine if the user will be notified of this event
            //and if the event will be repeated or not
        }

        private void UCModel_Load(object sender, EventArgs e)
        {
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                Namelb.ForeColor = SystemColors.ControlText;
                Catlb.ForeColor = SystemColors.ControlText;
                Locationlb.ForeColor = SystemColors.ControlText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                Namelb.ForeColor = SystemColors.Control;
                Catlb.ForeColor = SystemColors.Control;
                Locationlb.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                Namelb.ForeColor = SystemColors.Control;
                Catlb.ForeColor = SystemColors.Control;
                Locationlb.ForeColor = SystemColors.Control;
            }
        }

        public void UCModel_Click(object sender, EventArgs e)
        {
           if(ComponentModel.removeevent == true) 
           {
                Ownedby.RemoveEvent(this, Flp);
           }
        }
    }
}
