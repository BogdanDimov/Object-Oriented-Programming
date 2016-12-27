using System;
using DefiningClassesPart2.GenericList;
using DefiningClassesPart2.Matrix;
using DefiningClassesPart2.Space3D;
using DefiningClassesPart2.VersionAttribute;

namespace DefiningClassesPart2
{
    public class Start
    {
        public static void Main()
        {
            // Test Point3D
            Console.WriteLine("Distance between points: " + Distance3D.FindDistance(new Point3D(1, 2, 3), new Point3D(4, 5, 6)).ToString("F4"));
            Console.WriteLine();

            // Test PathStorage
            var pathToSave = new Point3D[] { new Point3D(3, 4, 5), new Point3D(1, 4, 8), new Point3D(11, 12, 13) };
            PathStorage.SavePath(pathToSave);
            var pathToRead = PathStorage.LoadPath();
            Console.WriteLine("Reading path from file...");
            foreach (var point in pathToRead)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine();

            // Test GenericList<T>
            var listOfInts = new GenericList<int>();
            listOfInts.Add(234123);
            listOfInts.Add(21342);
            listOfInts.Add(5123);
            listOfInts.Add(1234325123);
            Console.WriteLine("Printing the list:");
            Console.WriteLine(listOfInts);
            Console.WriteLine($"Min element = {listOfInts.Min()}");
            Console.WriteLine($"Max element = {listOfInts.Max()}");
            Console.WriteLine();
            var position = 1;
            listOfInts[position] = 32;
            Console.WriteLine($"List after setting element at position {position}:");
            Console.WriteLine(listOfInts);
            var value = 32;
            var index = listOfInts.IndexOf(value);
            Console.WriteLine($"Index of element found by value({value}): {index}");
            Console.WriteLine();
            listOfInts.RemoveAt(listOfInts.ElementsCount - 1);
            listOfInts.RemoveAt(listOfInts.ElementsCount - 1);
            Console.WriteLine("List after removing last 2 items:");
            Console.WriteLine(listOfInts);
            listOfInts.Clear();
            Console.WriteLine("List after calling the Clear method:");
            Console.WriteLine(listOfInts);

            var listOfStrings = new GenericList<string>();
            listOfStrings.Add("One");
            listOfStrings.Add("Two");
            listOfStrings.Add("Three");
            listOfStrings.Add("Four");
            Console.WriteLine("Printing the list:");
            Console.WriteLine(listOfStrings);
            Console.WriteLine($"Min element = {listOfStrings.Min()}");
            Console.WriteLine($"Max element = {listOfStrings.Max()}");
            Console.WriteLine();

            // Test Matrix<T>
            var matrix1 = new Matrix<int>(3, 3);
            var matrix2 = new Matrix<int>(3, 3);

            for (var i = 0; i < matrix1.Rows; i++)
            {
                for (var j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = i + j;
                }
            }

            for (var i = 0; i < matrix2.Rows; i++)
            {
                for (var j = 0; j < matrix2.Cols; j++)
                {
                    matrix2[i, j] = i + j;
                }
            }

            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine(matrix1 * matrix2);
            if (matrix1)
            {
                Console.WriteLine("There's at least one non-zero element.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("All elements are zero.");
                Console.WriteLine();
            }

            // Get instance of the VersionAttribute.
            var myVer = (MyVersionAttribute)Attribute.GetCustomAttribute(typeof(Matrix<int>), typeof(MyVersionAttribute));

            Console.WriteLine($"Version of the Matrix<T> class: {myVer.Major}.{myVer.Minor}\n");
        }
    }
}
