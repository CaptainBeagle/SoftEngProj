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
    public partial class View : Form
    {
        static DateTime now = DateTime.Now;
        public int Month = now.Month;
        public int Year = now.Year;

        public View()
        {
            InitializeComponent();
            this.Load += View_Load;
            
        }

        public void View_Load(object sneder, EventArgs e)
        {
            displayDays();
        }

        public void displayDays()
        {
            if(ComponentModel.tips == true)
            {
                ScheduleTips ST = new ScheduleTips();
                flowLayoutPanel2.Controls.Add(ST);
            }
            lbYear.Text = Year.ToString("");
            getMonth(Month);

            int theme = ComponentModel.savetheme;
            //Code that changes theme
            if(theme == 0)
            {
                this.BackColor = SystemColors.Menu;
                lbMonth.ForeColor = SystemColors.ControlText; 
                lbYear.ForeColor = SystemColors.ControlText;
                label1.ForeColor = SystemColors.ControlText;
                label2.ForeColor = SystemColors.ControlText;
                label3.ForeColor = SystemColors.ControlText;
                label4.ForeColor = SystemColors.ControlText;
                label5.ForeColor = SystemColors.ControlText;
                label6.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
            }
            else if(theme == 1) 
            {
                this.BackColor = SystemColors.ControlText;
                lbMonth.ForeColor = SystemColors.Control;
                lbYear.ForeColor = SystemColors.Control;
                label1.ForeColor = SystemColors.Control;
                label2.ForeColor = SystemColors.Control;
                label3.ForeColor = SystemColors.Control;
                label4.ForeColor = SystemColors.Control;
                label5.ForeColor = SystemColors.Control;
                label6.ForeColor = SystemColors.Control;
                label7.ForeColor = SystemColors.Control;
            }
            else if (theme == 2)
            {

            }
            else if (theme == 3)
            {

            }
            else if (theme == 4)
            {

            }

            EventView.CurrentMonth = lbMonth.Text;
            EventView.CurrentYear = lbYear.Text;

            //You have to clear the container of any old data before putting new data in
            flowLayoutPanel1.Controls.Clear();

            //Get first day of month
            DateTime startofmonth = new DateTime(Year, Month, 1);

            //Get number of days in the month
            int days = DateTime.DaysInMonth(Year, Month);

            //convert startofmonth to int
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                ucDays.Owner = this;
                flowLayoutPanel1.Controls.Add(ucDays);
            }
            if(ComponentModel.tips == true)
            {

            }

        }

        public void getMonth(int M)
        {
            //getMonth changes what month label says based on the inputed value
            if (M == 1)
            {
                lbMonth.Text = "January";
            }
            else if (M == 2)
            {
                lbMonth.Text = "February";
            }
            else if (M == 3)
            {
                lbMonth.Text = "March";
            }
            else if (M == 4)
            {
                lbMonth.Text = "April";
            }
            else if (M == 5)
            {
                lbMonth.Text = "May";
            }
            else if (M == 6)
            {
                lbMonth.Text = "June";
            }
            else if (M == 7)
            {
                lbMonth.Text = "July";
            }
            else if (M == 8)
            {
                lbMonth.Text = "August";
            }
            else if (M == 9)
            {
                lbMonth.Text = "September";
            }
            else if (M == 10)
            {
                lbMonth.Text = "October";
            }
            else if (M == 11)
            {
                lbMonth.Text = "November";
            }
            else if (M == 12)
            {
                lbMonth.Text = "December";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Month + 1) > 12)
            {
                Month = 1;
                Year++;
                displayDays();
            }
            else
            {
                Month++;
                displayDays();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Month - 1) < 1)
            {
                Month = 12;
                Year -= 1;
                displayDays();
            }
            else
            {
                Month -= 1;
                displayDays();
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SettingView sv = new SettingView();
            sv.Owner = this;
            sv.Show();
            
        }
    }
}
