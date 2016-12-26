namespace DefiningClassesPart2.Space3D
{
    public class Path
    {
        public Path(Point3D[] sequence)
        {
            Sequence = sequence;
        }

        public Point3D[] Sequence { get; }
    }
}