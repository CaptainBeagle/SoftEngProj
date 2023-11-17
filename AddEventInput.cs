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
    public partial class AddEventInput : Form
    {
        public AddEventInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add If statements to translate user inputs into correct ints
            //Add Category dropdown box and have the user input replace "Placeholder"
            EventView.AddEvent(textBox1.Text, textBox2.Text, "Placeholder", 000, 100, RepeatEvent.SelectedItem.ToString(), Reminder.SelectedItem.ToString());
        }
    }
}
