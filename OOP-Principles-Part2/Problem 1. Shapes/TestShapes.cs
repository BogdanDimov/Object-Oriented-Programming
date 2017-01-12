using System;

namespace OOP_Principles_Part2.Problem_1._Shapes
{
    public static class TestShapes
    {
        // Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

        public static void TestSurfaceCalculation()
        {
            Shape[] shapes = new Shape[] { new Triangle(3, 3.3), new Rectangle(3, 5.5), new Square(2.22) };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} area {shape.CalculateSurface():f2}");
            }

            Console.WriteLine();
        }
    }
}
