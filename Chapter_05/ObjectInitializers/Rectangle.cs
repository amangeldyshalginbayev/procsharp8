using System;

namespace ObjectInitializers
{
    public class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get => topLeft;
            set => topLeft = value;
        }

        public Point BottomRight
        {
            get => bottomRight;
            set => bottomRight = value;
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]",
                topLeft.X, topLeft.Y, topLeft.Color,
                bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
    }
}