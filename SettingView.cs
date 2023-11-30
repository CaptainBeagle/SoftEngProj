using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngProj
{
    public partial class SettingView : Form
    {
        public View Owner {  get; set; }
        public SettingView()
        {
            InitializeComponent();
            
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Menu;
                CalDisplay.ForeColor = SystemColors.ControlText;
                TipDisplay.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                comboBox1.BackColor = SystemColors.Window;
                comboBox1.ForeColor = SystemColors.WindowText;
                checkBox1.BackColor = SystemColors.Control;
                checkBox1.ForeColor = SystemColors.ControlText;
                checkBox2.BackColor = SystemColors.Control;
                checkBox2.ForeColor = SystemColors.ControlText;
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlText;
                CalDisplay.ForeColor = SystemColors.Control;
                TipDisplay.ForeColor = SystemColors.Control;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                comboBox1.BackColor = SystemColors.ControlDarkDark;
                comboBox1.ForeColor = SystemColors.Control;
                checkBox1.BackColor = SystemColors.ControlText;
                checkBox1.ForeColor = SystemColors.Control;
                checkBox2.BackColor = SystemColors.ControlText;
                checkBox2.ForeColor = SystemColors.Control;
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
                CalDisplay.ForeColor = SystemColors.Control;
                TipDisplay.ForeColor = SystemColors.Control;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                comboBox1.BackColor = SystemColors.GradientInactiveCaption;
                comboBox1.ForeColor = SystemColors.Control;
                checkBox1.BackColor = SystemColors.GradientActiveCaption;
                checkBox1.ForeColor = SystemColors.Control;
                checkBox2.BackColor = SystemColors.GradientActiveCaption;
                checkBox2.ForeColor = SystemColors.Control;
            }
            
            if(ComponentModel.dateorder == true) 
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if(ComponentModel.tips == true) 
            { 
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            comboBox1.SelectedIndex = 0;
        }

        private void SettingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentModel.savetheme = comboBox1.SelectedIndex;
            if(checkBox1.Checked ==  true)
            {
                ComponentModel.dateorder = true;
            }
            else 
            { 
                ComponentModel.dateorder = false; 
            }
            if(checkBox2.Checked == true) 
            { 
                ComponentModel.tips = true;
            }
            else if(checkBox2.Checked == false) 
            { 
                ComponentModel.tips = false; 
            }
            
            Owner.displayDays();
        }
    }
}
