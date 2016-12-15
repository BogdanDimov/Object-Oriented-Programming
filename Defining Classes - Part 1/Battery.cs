using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    public class Battery
    {
        public BatteryType Type { get; private set; }
        public double Voltage { get; private set; }
        public int Capacity { get; private set; }

        public Battery(BatteryType type = BatteryType.LiIon, double voltage = 3.6, int capacity = 2000)
        {
            this.Type = type;
            this.Voltage = voltage;
            this.Capacity = capacity;
        }

        public enum BatteryType
        {
            LiIon,
            LiPo,
            NiMH,
            NiCd,
        }
    }
}
