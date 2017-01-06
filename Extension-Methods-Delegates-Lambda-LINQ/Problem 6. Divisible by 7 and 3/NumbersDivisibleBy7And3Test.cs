namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_6._Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDivisibleBy7And3Test
    {
        public static void TestNumbersDivisibleBy7And3()
        {
            var numbers = new List<int>() { 21, 24, 131, 13, 2, 63, 78, 64, 4563, 147, 6, 7, 3, 49 };
            var numbersDivisibleBy7And3Lambda = NumbersDivisibleBy7And3.FindNumbersDivisibleBy7And3Lambda(numbers);
            var numbersDivisibleBy7And3LINQ = NumbersDivisibleBy7And3.FindNumbersDivisibleBy7And3LINQ(numbers);
            Console.WriteLine("Testing FindNumbersDivisibleBy7And3() using Lambda...");
            Console.WriteLine(String.Join(", ", numbersDivisibleBy7And3Lambda));
            Console.WriteLine();
            Console.WriteLine("Testing FindNumbersDivisibleBy7And3() using LINQ...");
            Console.WriteLine(String.Join(", ", numbersDivisibleBy7And3LINQ));
            Console.WriteLine();
        }
    }
}
