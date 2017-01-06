namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_1._StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class StringBuilderExtensionsTest
    {
        public static void TestStringBuilderExtensions()
        {
            var text = new StringBuilder("my awesome text");
            Console.WriteLine("Substring(5,5) of \"my awesome text\" returned: " + text.Substring(5, 5));
            Console.WriteLine();
        }
    }
}
