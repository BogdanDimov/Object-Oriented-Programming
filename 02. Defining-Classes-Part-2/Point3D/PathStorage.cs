using System.Collections.Generic;
using System.IO;

namespace DefiningClassesPart2.Space3D
{
    public static class PathStorage
    {
        private static readonly string Filename = "path.txt";

        public static void SavePath(Point3D[] points)
        {
            using (StreamWriter outputFile = new StreamWriter(Filename))
            {
                foreach (var point in points)
                {
                    outputFile.WriteLine($"{point.X} {point.Y} {point.Z}");
                }
            }
        }

        public static void LoadPath()
        {
            //var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), $"\\{filename}");
            List<Point3D> path = new List<Point3D>();

            using (StreamReader sr = new StreamReader(Filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line.Split(' ');
                    path.Add(new Point3D(line[0], line[1], line[0]));
                }
            }
        }
    }
}