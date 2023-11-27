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
        EventView Ev = new EventView();
        public EventView Owner { get; set; }
        public AddEventInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add If statements to translate user inputs into correct ints
            int S = 0;
            int E = 0;
            if(Starthour.SelectedItem.ToString() == "12:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 000;
            }
            else if (Starthour.SelectedItem.ToString() == "1:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 100;
            }
            else if (Starthour.SelectedItem.ToString() == "2:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 200;
            }
            else if (Starthour.SelectedItem.ToString() == "3:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 300;
            }
            else if (Starthour.SelectedItem.ToString() == "4:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 400;
            }
            else if (Starthour.SelectedItem.ToString() == "5:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 500;
            }
            else if (Starthour.SelectedItem.ToString() == "6:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 600;
            }
            else if (Starthour.SelectedItem.ToString() == "7:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 700;
            }
            else if (Starthour.SelectedItem.ToString() == "8:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 800;
            }
            else if (Starthour.SelectedItem.ToString() == "9:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 900;
            }
            else if (Starthour.SelectedItem.ToString() == "10:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 1000;
            }
            else if (Starthour.SelectedItem.ToString() == "11:00" && AmPm1.SelectedItem.ToString() == "Am")
            {
                S = 1100;
            }
            else if (Starthour.SelectedItem.ToString() == "12:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1200;
            }
            else if (Starthour.SelectedItem.ToString() == "1:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1300;
            }
            else if (Starthour.SelectedItem.ToString() == "2:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1400;
            }
            else if (Starthour.SelectedItem.ToString() == "3:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1500;
            }
            else if (Starthour.SelectedItem.ToString() == "4:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1600;
            }
            else if (Starthour.SelectedItem.ToString() == "5:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1700;
            }
            else if (Starthour.SelectedItem.ToString() == "6:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1800;
            }
            else if (Starthour.SelectedItem.ToString() == "7:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 1900;
            }
            else if (Starthour.SelectedItem.ToString() == "8:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 2000;
            }
            else if (Starthour.SelectedItem.ToString() == "9:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 2100;
            }
            else if (Starthour.SelectedItem.ToString() == "10:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 2200;
            }
            else if (Starthour.SelectedItem.ToString() == "11:00" && AmPm1.SelectedItem.ToString() == "Pm")
            {
                S = 2300;
            }

            //If you find a way to use the endtime variable, create if statements for E
            //  If more than one event, cancel action and make user change starttime
            Ev.AddEvent(textBox1.Text, textBox2.Text, Category.SelectedItem.ToString(), S, E, RepeatEvent.SelectedItem.ToString(), Reminder.SelectedItem.ToString());
        }
        
        private void AddEventInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Close();
            Ev.Show();
        }
    }
}
