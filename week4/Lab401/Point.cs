using System;

namespace Lab4
{
	public class Point
	{
        //propeties
        public double _x;
        public double _y;

        public double x {
            get { return _x; }
            set
            {
                _x = value;
            }
        }

        public double y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }
       


        //constructor
        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public Point(Point a)
        {
            _x = a._x;
            _y = a._y;
        }
       
        public Point(double x, double y)
        {
            _x = x;
            _y = y;

        }


		
	}
}

