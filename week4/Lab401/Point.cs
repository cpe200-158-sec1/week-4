using System;

namespace Lab4
{
	public class Point
	{
        private double _x,_y;

        public double x
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

        public double y
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
            _x = 0;
            _y = 0;
		}

        public Point(Point p )
        {
            _x = p.x;
            _y = p.y;
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            string outputstring = "";
            return outputstring;
        }
    }
}

