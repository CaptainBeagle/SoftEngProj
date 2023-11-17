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
        public static bool tips = true;
        /*public static string name = string.Empty;
        public static string location = string.Empty;
        public static string category = string.Empty;
        public static int start = 0;
        public static int end = 0;
        public static string repeat = string.Empty;
        public static string remind = string.Empty;*/
        public ComponentModel()
        {
            InitializeComponent();
        }

        public ComponentModel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
