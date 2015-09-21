using System;

namespace Lab4
{
	public class Point
	{
        private double _x;
        private double _y;
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        
		public Point ()
		{
            x = 0.0;
            y = 0.0;
		}
        public Point(Point s)
        {
            x = s.x;
            y = s.y;
        }
        public Point(double ix, double iy)
        {
            x = ix;
            y = iy;
        }
        public override string ToString()
        {
            return String.Format("");
        }
    }
}

