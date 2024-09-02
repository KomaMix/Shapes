using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes.Shapes
{
    internal class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB < sideC || sideA + sideC < sideB || sideC + sideB < sideA)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double GetArea()
        {
            // Полупериметр
            double p = (SideA + SideB + SideC) / 2;

            // Вычисление площади по формуле Герона
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsStupidTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 0.00001;
        }
    }
}
