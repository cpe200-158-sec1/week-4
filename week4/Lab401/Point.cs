using System;

namespace Lab4
{
	public class Point
	{
        private double _x, _y;
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
            _x = _y = 0;                      
		}
        public Point(Point a)
        {
            _x = a._x;
            _y = a._y;
        }
        public Point(double x,double y)
        {
            x = _x;
            y = _y;
        }
     
    }
}

