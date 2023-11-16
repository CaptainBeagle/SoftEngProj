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
