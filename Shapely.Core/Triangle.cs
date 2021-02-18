using System;
using System.Collections.Generic;
using System.Text;

namespace Shapely.Core
{
    public class Triangle : IShape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;


        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException();
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static bool IsPythagor(double kat1, double kat2, double hyp)
        {
            return Math.Pow(kat1, 2) + Math.Pow(kat2, 2) == Math.Pow(hyp, 2);
        }

        public bool IsRight()
        {
            return IsPythagor(a, b, c) || IsPythagor(a, c, b) || IsPythagor(c, b, a);
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public double GetSquare()
        {
            var halfPer = GetPerimeter() / 2;
            return Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
        }
    }
}
