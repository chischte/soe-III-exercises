using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Polygon
    {
        public abstract int NumSides { get; }
        public int Degrees
        {
            get { return (NumSides - 2) * 180; }
        }
        public abstract float Area();
    }
}
