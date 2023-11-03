using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngProj
{
    public partial class EventClass : Component
    {
        public EventClass()
        {
            InitializeComponent();
        }

        public EventClass(IContainer container, string EName, string ELocation, string Category, string Time, string Repeat, string Reminders)
        {
            //this is called with:
            //"new EventClass([The "UserControlDay" that was clicked on by the user],[whatever name of event is inputed by user],[Location inputed by user],[Category user chose],[Repitition user chose],[Reminder freq user chose]
            container.Add(this);
            
            InitializeComponent();
        }
    }
}
