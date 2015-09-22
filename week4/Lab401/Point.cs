using System;

namespace Lab4
{
    public class Point
    {

        private double _x;
        private double _y;
        public override string ToString()
        {
            return string.Format("center({0},{1},",_x,_y);
        }
        public Point()
        {
            _x = 0;
            _y = 0;
        }
        public Point(Point obj)
        {
            _x = obj.X;
            _y = obj.Y;
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double X {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}

