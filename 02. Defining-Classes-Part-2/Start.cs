using Generics;
using Point3D;
using Point3D.Distance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2
{
    class Start
    {
        static void Main()
        {
            //Console.WriteLine("Distance between points: " + Distance3D.FindDistance(new Point3d(1, 2, 3), new Point3d(4, 5, 6)).ToString("F4"));

            //var listOfInts = new GenericList<int>();
            //listOfInts.Add(234123);
            //listOfInts.Add(21342);
            //listOfInts.Add(5123);
            //listOfInts.Add(1234325123);
            //Console.WriteLine("Printing the list:");
            //Console.WriteLine(listOfInts);
            //Console.WriteLine($"Min element = {listOfInts.Min()}");
            //Console.WriteLine($"Max element = {listOfInts.Max()}");
            //var position = 1;
            //listOfInts[position] = 32;
            //Console.WriteLine($"List after setting element at position {position}:");
            //Console.WriteLine(listOfInts);
            //var index = listOfInts.IndexOf(32);
            //Console.WriteLine($"Index of element found by value: {index}");
            //listOfInts.RemoveAt(listOfInts.ElementsCount - 1);
            //listOfInts.RemoveAt(listOfInts.ElementsCount - 1);
            //Console.WriteLine("List after removing last 2 items:");
            //Console.WriteLine(listOfInts);
            //listOfInts.Clear();
            //Console.WriteLine("List after calling the Clear method:");
            //Console.WriteLine(listOfInts);

            var listOfStrings = new GenericList<string>();
            listOfStrings.Add("One");
            listOfStrings.Add("Two");
            listOfStrings.Add("Three");
            listOfStrings.Add("Four");
            Console.WriteLine("Printing the list:");
            Console.WriteLine(listOfStrings);
            Console.WriteLine($"Min element = {listOfStrings.Min()}");
            Console.WriteLine($"Max element = {listOfStrings.Max()}");
        }
    }
}
