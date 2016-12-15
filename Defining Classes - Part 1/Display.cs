using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    public class Display
    {
        public int Colors { get; private set; }
        public string Resolution { get; private set; }
        public double Inches { get; private set; }

        public Display(int colors = 0, string resolution = null, double inches = 0)
        {
            this.Colors = colors;
            this.Resolution = resolution;
            this.Inches = inches;
        }
    }
}
