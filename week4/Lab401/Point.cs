using System;

namespace Lab4
{
	public class Point
	{
        private double _x;
        private double _y;
        public double X
        {
            get { return _x; }
            set { _x = value; }

        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
		public Point ()
		{
            X = 0;
            Y = 0;
		}
        public Point(Point a)
        {
            X = a.X;
            Y = a.Y;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return String.Format("[{0},{1}]", X, Y);
        }
    }       
}

