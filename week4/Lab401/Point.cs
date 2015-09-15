using System;

namespace Lab4
{
	public class Point
	{
		
            private double _x;
            private double _y;


        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public Point()
        {
            X = 0.0;
            Y = 0.0;
        }

        public Point(Point iP)
        {
            X = iP.X;
            Y = iP.X;
        }

        public Point (double iX, double iY)
        {
            X = iX;
            Y = iY;
        }

        //public override string tostring()
        //{
        //    return string.format("{0},{1}", x, y);
        //}

    
	}
}

