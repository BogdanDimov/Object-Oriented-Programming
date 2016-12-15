using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    public class GSM
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Display GsmDisplay { get; private set; }
        public Battery GsmBattery { get; private set; }
        public bool HasCamera { get; private set; }
        public static GSM IPhone4S = new GSM("Apple", "iPhone 4S", new Display(16000000, "640x960", 3.5), new Battery(Battery.BatteryType.LiPo, capacity: 1432), 2011, true);

        public GSM(string manufacturer, string model, Display gsmDisplay, Battery gsmBattery, int year = 2010, bool hasCamera = true)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.GsmDisplay = GsmDisplay;
            this.GsmBattery = gsmBattery;
            this.Year = year;
            this.HasCamera = hasCamera;
        }

        public override string ToString()
        {
            return "Mobile phone " + Manufacturer + " " + Model +
                "\nYear of manufacture: " + Year +
                "\nDisplay size: " + GsmDisplay.Inches +
                "in\nBuilt-in camera: " + (HasCamera ? "Yes" : "No");
        }
    }
}
