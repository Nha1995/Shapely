using Shapely.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace Shapely.Tests
{
    public class Tests
    {
        [Fact]
        public void Triangle_Negative()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Fact]
        public void Triangle_Positive()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(12, triangle.GetPerimeter());
            Assert.Equal(6, triangle.GetSquare());
            Assert.True(triangle.IsRight());

            var notRightTriangle = new Triangle(6, 7, 8);
            Assert.False(notRightTriangle.IsRight());
        }

        [Fact]
        public void Circle_Positive()
        {
            var circle = new Circle(2);
            Assert.Equal(12.57, Math.Round(circle.GetSquare(), 2));
            Assert.Equal(12.57, Math.Round(circle.GetPerimeter(), 2));
        }

        [Fact]
        public void CalculateSquareWithoutKnowingConcreteShape()
        {
            var shapes = new List<IShape>();
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Circle(2));

            double cumulativeSquare = 0;
            foreach (var shape in shapes) {
                cumulativeSquare += shape.GetSquare();
            }

            Assert.Equal(6 + 12.57, Math.Round(cumulativeSquare, 2));
        }
    }
}
