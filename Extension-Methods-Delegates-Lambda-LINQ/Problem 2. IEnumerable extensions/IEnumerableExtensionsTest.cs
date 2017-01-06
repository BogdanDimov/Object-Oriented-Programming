namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_2._IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensionsTest
    {
        public static void TestIEnumerableExtensions()
        {
            var intsList = new List<float>();
            intsList.Add(3f);
            intsList.Add(33f);
            intsList.Add(333.33f);

            Console.WriteLine("Testing IEnumerable<T> extensions...");
            Console.WriteLine("sum = " + intsList.Sum());
            Console.WriteLine("product = " + intsList.Product());
            Console.WriteLine("min = " + intsList.Min());
            Console.WriteLine("max = " + intsList.Max());
            Console.WriteLine("average = " + intsList.Average());
            Console.WriteLine();
        }
    }
}
