using System;

namespace Lab4
{
    public class Circle : Point
    {
        private Point _center;
        private double _radius;

        public override string ToString()
        {
            return string.Format("Circle: center({0},{1}), radius={2}, area={3},", _center.X, _center.Y, _radius, getArea());
        }
        public Circle()
        {
            _center = new Point();
            _radius = 1;
        }
        public Circle(Circle obj)
        {
            _center = new Point(obj.Center); // not sure
            _radius = obj.Radius;
        }
        public Circle(double x, double y, double radius)
        {
            _center = new Point(x, y);
            _radius = radius;
        }
        public Circle(double radius)
        {
            _center = new Point();
            _radius = radius;
        }

        public void setCircle(double x, double y, double radius)
        {
            this._center = new Point(x, y);
            this._radius = radius;
        }
        public double getArea()
        {
            return 3.14159265358979 * _radius * _radius;
        }
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; } 
        }
        public Point Center
        {
            get { return _center; }
            set { _center = value; }
        }

    }
}

