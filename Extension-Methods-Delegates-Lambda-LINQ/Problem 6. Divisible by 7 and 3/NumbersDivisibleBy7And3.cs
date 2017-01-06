namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_6._Divisible_by_7_and_3
{
    using System.Collections.Generic;
    using System.Linq;

    public class NumbersDivisibleBy7And3
    {
        public static List<int> FindNumbersDivisibleBy7And3Lambda(List<int> numbers)
        {
            var numbersDivisibleBy7And3 = numbers.Where(number => number % 3 == 0 && number % 7 == 0).ToList();

            return numbersDivisibleBy7And3;
        }

        public static List<int> FindNumbersDivisibleBy7And3LINQ(List<int> numbers)
        {
            var numbersDivisibleBy7And3 =
                (from number in numbers
                 where number % 3 == 0 && number % 7 == 0
                 select number).ToList();

            return numbersDivisibleBy7And3;
        }
    }
}
