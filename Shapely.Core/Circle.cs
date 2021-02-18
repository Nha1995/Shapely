using System;
using System.Collections.Generic;
using System.Text;

namespace Shapely.Core
{
    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
