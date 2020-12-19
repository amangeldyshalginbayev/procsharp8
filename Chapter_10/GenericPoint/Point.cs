namespace GenericPoint
{
    public class Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point(T xPos, T yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }

        public T X
        {
            get => _xPos;
            set => _xPos = value;
        }

        public T Y
        {
            get => _yPos;
            set => _yPos = value;
        }

        public void ResetPoint()
        {
            _xPos = default;
            _yPos = default;
        }

        public override string ToString() => $"[{_xPos}, {_yPos}]";
    }
}