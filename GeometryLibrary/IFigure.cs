using System.Windows;

namespace GeometryLibrary
{
    public interface IFigure
    {
        Point Coordinates { get; set; }  // Координати фігури
        void Move(IMoveStrategy strategy, int x, int y);  // Метод для переміщення фігури
    }
}
