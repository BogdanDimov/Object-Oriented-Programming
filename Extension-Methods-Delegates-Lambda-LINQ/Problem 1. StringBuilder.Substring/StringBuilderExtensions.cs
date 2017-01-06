namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_1._StringBuilder.Substring
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }
    }
}
