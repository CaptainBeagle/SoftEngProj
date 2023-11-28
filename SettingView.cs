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

            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlText;
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
            if(ComponentModel.dateorder == true) 
            {
                checkBox1.Checked = true;
            }
            if(ComponentModel.tips == true) 
            { 
                checkBox2.Checked = true;
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
            else 
            { 
                ComponentModel.tips = false; 
            }
            
            Owner.displayDays();
        }
    }
}
