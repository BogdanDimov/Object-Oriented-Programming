using System;

namespace Defining_Classes___Part_1
{
    class GSMTest
    {
        private const int arrayLength = 3;
        private static string[] models = { "Lumia 1020", "G5", "Moto G (3rd gen)" };
        private static string[] manufacturers = { "Nokia", "LG", "Motorola" };
        private static decimal[] prices = { 400m, 430m, 170m };
        private static string[] owners = { "Koko", "Doko", "Tsoko" };

        private static Battery[] batteries = { new Battery(hoursTalk: 19, hoursIdle: 384, type: BatteryType.LiIon),
                                        new Battery(hoursTalk: 20, hoursIdle: 400, type: BatteryType.LiIon),
                                        new Battery(type: BatteryType.LiIon) };

        private static Display[] displays = { new Display(16000000, 4.5),
                                       new Display(16000000, 5.3),
                                       new Display(16000000, 5.0) };

        public static void TestGSM()
        {
            GSM[] gsmArray = new GSM[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                gsmArray[i] = new GSM(models[i], manufacturers[i], prices[i], owners[i], batteries[i], displays[i]);
            }

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
