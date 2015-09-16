using System;

namespace Lab4
{
    public class Point
    {
        //## Propeties:
        //    - double x, y : represent a point in 2D cartesian coordinate system 
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
        //## Constructors:
        //        - Point(): default
        //        - Point(Point): copy constructor
        //        - Point(double x, double y): take x and y as parementers
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }
        //## Methods
        public override string ToString()
        {
            return "center("+X+","+Y+")";
        }


    }
}

