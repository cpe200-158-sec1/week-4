using System;

/*
# 1. Point Class:
## Propeties:
- double x, y : represent a point in 2D cartesian coordinate system 

## Constructors:
- Point(): default
- Point(Point): copy constructor
- Point(double x, double y): take x and y as parementers

## Methods
- overriding ToString()
*/

namespace Lab4
{
    public class Point
    {
        private double _x, _y;

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

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public Point(Point P)
        {
            _x = P._x;
            _y = P._y;
        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}

