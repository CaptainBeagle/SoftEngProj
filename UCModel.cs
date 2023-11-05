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
    public partial class UCModel : UserControl
    {
        public UCModel(string Ename, string Elocation, string Ecategory, int Estarttime, int Eendtime, string repeatability, string reminders)
        {
            InitializeComponent();
        }
        //ToDo: Create Labels, Add method to get info inputed by user to text of labels, and have it display appropriately in EventView of appropriate date.
    }
}
