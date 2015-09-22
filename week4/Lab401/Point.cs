using System;

namespace Lab4
{
    public class Point
    {
        private double _X;
        private double _Y;

        public double X
        {
            get { return _X; }
            set { _X = value; }
        }

        public double Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        public Point()
        {
            X = 0.0;
            Y = 0.0;
        }

        public Point(Point a)
        {
            X = a.X;
            Y = a.Y;
        }

        public Point(double a, double b)
        {
            X = a;
            Y = b;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}
