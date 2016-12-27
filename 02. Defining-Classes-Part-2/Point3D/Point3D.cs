namespace DefiningClassesPart2.Space3D
{
    public struct Point3D
    {
        private static readonly Point3D Origin = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X
        {
            get;
        }

        public int Y
        {
            get;
        }

        public int Z
        {
            get;
        }

        public override string ToString()
        {
            return string.Format($"({X}, {Y}, {Z})");
        }
    }
}
