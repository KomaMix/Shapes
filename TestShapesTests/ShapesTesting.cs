using TestShapes.Shapes;

namespace TestShapesTests
{
    public class ShapesTesting
    {
        [Fact]
        public void CircleAreaTest()
        {
            double radius = 3;
            Circle circle = new Circle(radius);

            double area = circle.GetArea();
            Assert.Equal(Math.PI * 9, area, 0.0001);
        }

        [Fact]
        public void SquareAreaTest()
        {
            double side = 3;
            Square square = new Square(side);

            double area = square.GetArea();
            Assert.Equal(9, area, 0.0001);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.GetArea();
            Assert.Equal(6, area, 0.0001);
        }

        [Fact]
        public void TriangleIsStupidTest()
        {
            Triangle triangle = new Triangle(5, 12, 13);

            bool isRight = triangle.IsRightTriangle();

            Assert.True(isRight);
        }
    }
}