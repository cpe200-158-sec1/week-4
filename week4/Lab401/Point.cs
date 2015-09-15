using System;

namespace Lab4
{
	public class Point
	{
        private double _x;
        private double _y;
        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }

        public Point ()
		{
            X = 0;
            Y = 0;
		}
        public Point (Point pPoint)
        {
            X = pPoint.X;
            Y = pPoint.Y;
        }
        public Point (double pX, double pY)
        {
            X = pX;
            Y = pY;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}

