using CalcAreaLib;
namespace CalcAreaLib.Test
{
    public class LibTest
    {
        [Fact]
        public void CircleAreaIsCorrect()
        {
            var circle = new Circle(5);
            Assert.Equal(Math.PI * 5 * 5, circle.CalculateArea());
        }
        [Fact]
        public void CircleAreaIsIncorrect()
        {
            var circle = new Circle(5);
            Assert.NotEqual(Math.PI * 6 * 5, circle.CalculateArea());
        }

        [Fact]
        public void TriangleAreaIsCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea());
        }
        [Fact]
        public void TriangleAreaIsIncorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.NotEqual(7, triangle.CalculateArea());
        }

        [Fact]
        public void RightTriangleIsCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void RightTriangleIsIncorrect()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void InvalidRadiusExceptionIsCorrect()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void InvalidSidesExceptionIsCorrect()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}