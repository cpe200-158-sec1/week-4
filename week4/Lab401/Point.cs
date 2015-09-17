using System;

namespace Lab4
{
    public class Point
    {        
        //## Propeties
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
        //## Constructors
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
        public Point(double a, double b)
        {
            X = a;
            Y = b;
        }

        //## Methods
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
        //////////////////////////////////////////////
    
   }
}


