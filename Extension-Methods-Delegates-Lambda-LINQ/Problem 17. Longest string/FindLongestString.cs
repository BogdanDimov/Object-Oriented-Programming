namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_17._Longest_string
{
    using System;
    using System.Linq;

    public static class LongestString
    {
        public static string FindLongestString(this string[] strings)
        {
            return strings.OrderByDescending(str => str.Length).First();
        }

        public static void TestLongestString()
        {
            string[] strings = new string[] { "shte", "se", "pobarkam", "be", "Meeeennn" };
            Console.WriteLine("The longest string from the array { " + String.Join(", ", strings) + " } is: ");
            Console.WriteLine(FindLongestString(strings));
            Console.WriteLine();
        }
    }
}
