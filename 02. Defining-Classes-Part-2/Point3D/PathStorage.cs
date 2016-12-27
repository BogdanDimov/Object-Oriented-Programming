using System.Collections.Generic;
using System.IO;

namespace DefiningClassesPart2.Space3D
{
    public static class PathStorage
    {
        private static readonly string Filename = "path.txt";

        public static void SavePath(Point3D[] points)
        {
            using (var outputFile = new StreamWriter(Filename))
            {
                foreach (var point in points)
                {
                    outputFile.WriteLine(string.Join(", ", new string[] { point.X.ToString(), point.Y.ToString(), point.Z.ToString() }));
                }
            }
        }

        public static List<Point3D> LoadPath()
        {
            var path = new List<Point3D>();

            using (var sr = new StreamReader(Filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] coords = line.Split(',');
                    path.Add(new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2])));
                }
            }

            return path;
        }
    }
}