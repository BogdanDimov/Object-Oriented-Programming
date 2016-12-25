using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D.Distance
{
    public static class Distance3D
    {
        public static double FindDistance(Point3d p1, Point3d p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) +
                             (p1.Y - p2.Y) * (p1.Y - p2.Y) +
                             (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }
    }
}