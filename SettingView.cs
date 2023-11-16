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
            comboBox1.SelectedIndex = 0;
        }

        private void SettingView_FormClosed(object sender, FormClosedEventArgs e)
        {
            View.theme = comboBox1.SelectedIndex;
            View v = new View();
            v.displayDays();
        }
    }
}
