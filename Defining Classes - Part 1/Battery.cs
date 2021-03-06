﻿namespace Defining_Classes___Part_1
{
    public class Battery
    {
        public string Model { get; set; }
        public int? HoursIdle { get; set; }
        public int? HoursTalk { get; set; }
        public BatteryType? Type { get; set; }

        public Battery(string model = null, int? hoursIdle = null, int? hoursTalk = null, BatteryType? type = null)
        {
            Model = model;
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalk;
            Type = type;
        }
    }

    public enum BatteryType
    {
        LiIon,
        LiPo,
        NiMH,
        NiCd,
    }
}
