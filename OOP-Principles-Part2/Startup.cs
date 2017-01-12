using OOP_Principles_Part2.Problem_1._Shapes;
using OOP_Principles_Part2.Problem_2._Bank_accounts;
using OOP_Principles_Part2.Problem_3._Range_Exceptions;

namespace OOP_Principles_Part2
{
    public class Startup
    {
        public static void Main()
        {
            TestShapes.TestSurfaceCalculation();
            TestBankSystem.Test();
            ExceptionTest.Test();
        }
    }
}
