using System;

namespace Lab4
{
    public class Cylinder : Circle
    {


        private double _height;
        private Circle _circle;

        public override string ToString()
        {
            return string.Format("Cylinder: center=({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]",
                x, y, _circle.radius, _height, getSurface(), getVolume());
        }
        public double height
        {
            get { return _height; }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1;
                }
            }
        }

        public virtual double getSurface()
        {
            return ((2 * 3.14159265358979 * _circle.radius * _height) + (2 * _circle.getArea()));
        }
        public double getVolume()
        {
            return _circle.getArea() * _height;
        }

        public Cylinder()
        {
            _circle = new Circle();
            _height = 1;
        }

        public Cylinder(double r, double h)
        {
            _circle = new Circle(r);
            _height = h;
        }

        public Cylinder(double a, double b, double r, double h)
        {
            _circle = new Circle(x, y, r);
            _height = h;
        }
        public Cylinder(Circle x)
        {
            _circle = new Circle(x);
            _height = 1;
        }
        public Cylinder(Cylinder a)
        {
            _circle = new Circle(a._circle.center.x, a._circle.center.y, a._circle.radius);
            _height = a._height;
        }


    }
}

