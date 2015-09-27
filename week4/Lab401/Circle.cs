using System;
using Lab4;

namespace Lab4
{
	public class Circle : Point
    {
        private Point _center;
        private double _radius;

        public Point Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    _radius = 1.0;
                else
                    _radius = value;
            }
        }

        public Circle()
        {
            _center = new Point();
            _radius = 1;
        }

        public Circle(double radius)
        {
            _center = new Point();
            _radius = radius;
        }

        public Circle(double x, double y, double radius)
        {
            _center = new Point(x, y);
            _radius = radius;
        }

        public Circle(Circle obj)
        {
            _center = new Point(obj.Center);
            _radius = obj.Radius;
        }

        public void setCircle(double x, double y, double radius)
        {
            this._center = new Point(x, y);
            this._radius = radius;
        }

        public virtual double getArea()
        {
            return 3.14159265358979 * Radius * Radius;
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", _center.X, _center.Y, _radius, getArea());
        }
    }
}

