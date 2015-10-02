﻿using System;

namespace Lab401
{
	public class Point
	{
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x= value;}
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point( double x, double y)
        {
            X = x;
            Y = y;

        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;


        }

        public override string ToString()
        {
            return "Point ("+X+","+Y+" )";
        }

    }
}

