using System;

namespace Lab4
{
	public class Point
	{
            private double _x, _y;

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
            public Point()
            {
                 X = Y = 0;
            }

            public Point(double x = 0,double y = 0)
            {
                 X = x;
                 Y = y;
            }

            public Point(Point a)
            {
                this.X = a.X;
                this.Y = a.Y;
            }

            public override string ToString()
            {
                return string.Format("center : ({0},{1})", X, Y);
            }

	}
}
