using System;
using System.Globalization;

namespace OOP_Principles_Part2.Problem_3._Range_Exceptions
{
    public static class ExceptionTest
    {
        // Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
        // by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
        public static void Test()
        {
            int intRangeStart = 0;
            int intRangeEnd = 100;
            DateTime dtRangeStart = new DateTime(1980, 1, 1);
            DateTime dtRangeEnd = new DateTime(2013, 12, 31);

            try
            {
                Console.Write("Enter integer value: ");
                int intValue = int.Parse(Console.ReadLine());

                if (intValue < intRangeStart || intValue > intRangeEnd)
                {
                    throw new InvalidRangeException<int>(intRangeStart, intRangeEnd);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Enter DateTime in format dd.MM.yyyy: ");
                DateTime dtValue = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (dtValue < dtRangeStart || dtValue > dtRangeEnd)
                {
                    throw new InvalidRangeException<DateTime>(dtRangeStart, dtRangeEnd);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
