using System;
using System.Text;
using GeometryLibrary;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            // Створюємо фігури
            IFigure circle = new Circle(5, 0, 0);
            IFigure square = new Square(4, 2, 3);
            IFigure triangle = new Triangle(6, 4, 5, 6);

            // Створюємо контекст для переміщення фігур
            FigureContext context = new FigureContext();

            // Переміщення кола
            context.SetStrategy(new CircleMover());
            Console.WriteLine($"Коло перед переміщенням: {circle.Coordinates}");
            context.MoveFigure(circle, 10, 5);
            Console.WriteLine($"Коло після переміщення: {circle.Coordinates}");

            // Переміщення квадрата
            context.SetStrategy(new SquareMover());
            Console.WriteLine($"\nКвадрат перед переміщенням: {square.Coordinates}");
            context.MoveFigure(square, -3, 7);
            Console.WriteLine($"Квадрат після переміщення: {square.Coordinates}");

            // Переміщення трикутника
            context.SetStrategy(new TriangleMover());
            Console.WriteLine($"\nТрикутник перед переміщенням: {triangle.Coordinates}");
            context.MoveFigure(triangle, 0, -5);
            Console.WriteLine($"Трикутник після переміщення: {triangle.Coordinates}");
        }
    }
}
