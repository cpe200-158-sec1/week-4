using System;

namespace Lab4
{
    public class Point
    {
        private double _x;
        private double _y;
        public override string ToString()
        {
            return string.Format("({0},{1},", _x, _y);
        }
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
        public Point()
        {
            x = 0;
            y = 0;

        }
        public Point(Point copy)
        {
            x = copy.x;
            y = copy.y;
        }
        public Point(double a, double b)
        {
            x = a;
            y = b;

        }

    }
}

