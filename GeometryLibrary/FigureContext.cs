namespace GeometryLibrary
{
    public class FigureContext
    {
        private IMoveStrategy _strategy;

        public void SetStrategy(IMoveStrategy strategy)
        {
            _strategy = strategy;
        }

        public void MoveFigure(IFigure figure, int x, int y)
        {
            if (_strategy != null)
            {
                _strategy.Move(x, y, figure);
            }
        }
    }
}
