using System.Windows;

namespace GeometryLibrary
{
    public class Square : IFigure
    {
        public Point Coordinates { get; set; }
        public double Side { get; set; }

        public Square(double side, int x = 0, int y = 0)
        {
            Side = side;
            Coordinates = new Point(x, y);
        }

        public void Move(IMoveStrategy strategy, int x, int y)
        {
            strategy.Move(x, y, this);
        }
    }
}
