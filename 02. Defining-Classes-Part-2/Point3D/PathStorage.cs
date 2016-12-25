using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D.Path
{
    public static class PathStorage
    {
        private static readonly string Filename = "path.txt";

        public static void SavePath(Point3d[] points)
        {
            using (StreamWriter outputFile = new StreamWriter(Filename))
            {
                foreach (var point in points)
                    outputFile.WriteLine($"{point.X} {point.Y} {point.Z}");
            }
        }

        public static void LoadPath()
        {
            //var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), $"\\{filename}");
            List<Point3d> path = new List<Point3d>();

            using (StreamReader sr = new StreamReader(Filename))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line.Split(' ');
                    path.Add(new Point3d(line[0], line[1], line[0]));
                }
            }
        }
    }
}