namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_2._IEnumerable_extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumberableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> source) where T : struct
        {
            dynamic sum = default(T);
            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> source) where T : struct
        {
            dynamic product = 1;
            foreach (var item in source)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> source) where T : struct
        {
            dynamic min = source.First();
            foreach (var item in source)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> source) where T : struct
        {
            dynamic max = source.First();
            foreach (var item in source)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> source) where T : struct
        {
            return (dynamic)source.Sum() / source.Count();
        }
    }
}
