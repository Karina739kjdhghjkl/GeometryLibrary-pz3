using System.Windows;

namespace GeometryLibrary
{
    public class CircleMover : IMoveStrategy
    {
        public void Move(int x, int y, IFigure figure)
        {
            figure.Coordinates = new Point(
                figure.Coordinates.X + x,
                figure.Coordinates.Y + y
            );
        }
    }
}
