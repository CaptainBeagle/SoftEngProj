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
    public partial class ScheduleTips : UserControl
    {
        public View V { get; set; }
        public ScheduleTips()
        {
            InitializeComponent();
        }

        public void ScheduleTips_Click(object sender, EventArgs e)
        {
            TipView TV = new TipView();
            TV.getname(name());
            TV.c = this;
            TV.O = V;
            TV.Show();
        }

        public string name()
        {
            return label1.Text;
        }

        private void ScheduleTips_Load(object sender, EventArgs e)
        {
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                label1.ForeColor = SystemColors.WindowText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                label1.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                label1.ForeColor = SystemColors.Control;
            }
            
            if(ComponentModel.T == 1)
            {
                label1.Text = "Learn Basic Navigation";
            }
            if (ComponentModel.T == 2)
            {
                label1.Text = "Scheduling Downtime";
            }
            if (ComponentModel.T == 3)
            {
                label1.Text = "Prioritizing Events";
            }
        }

        public void Re()
        {
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                label1.ForeColor = SystemColors.WindowText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                label1.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                label1.ForeColor = SystemColors.Control;
            }
            
            if (ComponentModel.T == 1)
            {
                label1.Text = "Learn Basic Navigation";
            }
            if (ComponentModel.T == 2)
            {
                label1.Text = "Scheduling Downtime";
            }
            if (ComponentModel.T == 3)
            {
                label1.Text = "Prioritizing Events";
            }
        }
    }
}
