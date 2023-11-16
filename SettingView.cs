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
        
        public SettingView()
        {
            InitializeComponent();
            
            if (View.theme == 0)
            {
                this.BackColor = SystemColors.Menu;

            }
            else if (View.theme == 1)
            {
                this.BackColor = SystemColors.ControlText;
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
            //View v = new View();
            //v.displayDays();
            //v.Show();
        }
    }
}
