using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D.Path
{
    public class Path
    {
        public Point3d[] Sequence { get; }

        public Path(Point3d[] sequence)
        {
            Sequence = sequence;
        }
    }
}