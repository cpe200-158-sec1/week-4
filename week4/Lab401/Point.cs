using System;

namespace Lab4
{
	public class Point
	{
        private double X;
        private double Y;
        public double x
        {
            get { return X; }
            set { X = value; }
        }
        public double y
        {
            get { return Y; }
            set { Y = value; }
        }
		public Point()
		{
            x = 0.0;
            y = 0.0;
		}
        public Point(Point a)
        {
            x = a.x;
            y = a.y;
        }
        public Point(double a, double b)
        {
            x = a;
            y = b;
        }
        public override string ToString()
        {
            return String.Format("");
        }
    }
}

