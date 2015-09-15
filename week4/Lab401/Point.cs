using System;

namespace Lab4
{
	public class Point
	{
        protected double _x;
        protected double _y;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Point ()
		{
            _x = 0.0;
            _y = 0.0;
        }

        public Point(Point cpy)
        {
            _x = cpy._x;
            _y = cpy._y;
        }

        public Point(double x1,double y1)
        {
            _x = x1;
            _y = y1;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})" , X , Y );
        }




    }
}

