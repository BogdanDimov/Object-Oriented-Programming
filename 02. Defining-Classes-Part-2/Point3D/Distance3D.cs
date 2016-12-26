using System;

namespace DefiningClassesPart2.Space3D
{
    public static class Distance3D
    {
        public static double FindDistance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(((p1.X - p2.X) * (p1.X - p2.X)) +
                             ((p1.Y - p2.Y) * (p1.Y - p2.Y)) +
                             ((p1.Z - p2.Z) * (p1.Z - p2.Z)));
        }
    }
}