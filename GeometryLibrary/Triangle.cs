using System.Windows;

namespace GeometryLibrary
{
    public class Triangle : IFigure
    {
        public Point Coordinates { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height, int x = 0, int y = 0)
        {
            Base = baseLength;
            Height = height;
            Coordinates = new Point(x, y);
        }

        public void Move(IMoveStrategy strategy, int x, int y)
        {
            strategy.Move(x, y, this);
        }
    }
}
