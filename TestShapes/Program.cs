using TestShapes.Shapes;

IShape shape;

Random rand = new Random();

bool flag = rand.Next(0, 2) == 1;

if (flag)
{
    shape = new Triangle(3, 4, 5);
} else
{
    shape = new Circle(2);
}

Console.WriteLine("Тип фигуры: " + shape.GetType().Name);
Console.WriteLine("Площадь фигуры: " + shape.GetArea());

if (shape.GetType() == typeof(Triangle) && shape is not null)
{
    Console.WriteLine("Этот треугольник " +
        ((shape as Triangle).IsRightTriangle() ? "прямоугольный" : "обычный"));
}
