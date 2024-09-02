using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes.Shapes
{
    public class Square : IShape
    {
        public double Side { get; }

        public Square(double side)
        {
            this.Side = side;
        }

        public double GetArea()
        {
            return this.Side * this.Side;
        }
    }
}
