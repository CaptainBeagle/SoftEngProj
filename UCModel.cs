using System;
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
        public UCModel(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            InitializeComponent();
            Namelb.Text = Ename;
            Catlb.Text = Ecategory;
            Locationlb.Text = Elocation;
        }

        private void UCModel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
