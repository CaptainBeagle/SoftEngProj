using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngProj
{
    public partial class ComponentModel : Component
    {
        public static int savetheme = 0;
        public static bool dateorder = false;
        public static bool removeevent = false;
        public static bool tips = true;
        public static string Rep = "";
        public static string Ename = string.Empty;
        public static string Elocation = string.Empty;
        public static string Ecategory = string.Empty;
        public static int Estart = 0;
        public static int Eend = 0;
        public static int dw = 0;
        public static int T = 0;
        public static string Erepeat = string.Empty;
        public static string Eremind = string.Empty;
        public ComponentModel()
        {
            InitializeComponent();
        }

        public ComponentModel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public static void RepeatEvent(string name, string location, string category, int start, int end, string repeat, string remind)
        {
            //Send info to UserControlDays
            if(repeat == "Every day")
            {
                Rep = "Every day";
            }
            else if(repeat == "Weekdays")
            {
                Rep = "Weekdays";
            }
            else if (repeat == "Weekends")
            {
                Rep = "Weekends";
            }
            else if (repeat == "Once a week")
            {
                Rep = "Once a week";
            }
            Ename = name;
            Elocation = location;
            Ecategory = category;
            Estart = start;
            Eend = end;
            Erepeat = repeat;
            Eremind = remind;
        }
    }
}
