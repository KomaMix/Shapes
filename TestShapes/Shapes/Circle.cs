using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
