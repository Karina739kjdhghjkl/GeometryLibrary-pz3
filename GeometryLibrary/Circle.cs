using System.Windows;

namespace GeometryLibrary
{
    public class Circle : IFigure
    {
        public Point Coordinates { get; set; }
        public double Radius { get; set; }

        public Circle(double radius, int x = 0, int y = 0)
        {
            Radius = radius;
            Coordinates = new Point(x, y);
        }

        public void Move(IMoveStrategy strategy, int x, int y)
        {
            strategy.Move(x, y, this);
        }
    }
}
