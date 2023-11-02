using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngProj
{
    public partial class EventView : Form
    {
        public static string CurrentMonth, CurrentYear, CurrentDay;
        public EventView()
        {
            InitializeComponent();
        }
         
        private void EventView_Load(object sender, EventArgs e)
        {
            DateLb.Text = CurrentMonth + "  " + CurrentDay + "  " + CurrentYear;
            //ToDo: Event creation and display
        }
    }
}
