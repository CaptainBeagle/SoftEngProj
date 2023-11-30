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
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }

        private void UserControlBlank_Load(object sender, EventArgs e)
        {
            if (ComponentModel.savetheme == 0)
            {
                this.BackColor = SystemColors.Window;
                
            }
            else if (ComponentModel.savetheme == 1)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                
            }
            else if (ComponentModel.savetheme == 2)
            {
                this.BackColor = SystemColors.GradientActiveCaption;
            }
        }
    }
}
