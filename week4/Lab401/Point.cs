using System;

namespace Lab4
{
	public class Point
	{
        private double _x, _y;
        public double x
        {
            get { return _x; }
        }
        public double y
        {
            get { return _y; }
        }


        public Point ()
		{
            _x = 0;
            _y = 0;
		}

        public Point(Point p)
        {
            _x = p._x;
            _y = p._y;
        }

        public Point(double x, double y) {
            this._x = x;
            this._y = y;
        }

        //Tostring
        public override string ToString()
        {
            string s = "555+";
            return s;
        }

    }
}

