using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3d
    {
        private static readonly Point3d origin = new Point3d(0, 0, 0);

        public Point3d(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3d Origin { get { return origin; } }
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }
    }
}
