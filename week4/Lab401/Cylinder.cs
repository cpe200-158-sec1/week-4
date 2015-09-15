using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
        private Circle _circle;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value < 0)
                {
                    _height = 1.0;
                }
                else
                {
                    _height = value;
                }
            }
        }
		public Cylinder()
		{
            _circle = new Circle();
            _height = 1;
		}
        public Cylinder(double radius, double height)
        {
            _circle = new Circle(radius);
            _height = height;
        }
        public Cylinder(double x, double y, double radius, double height)
        {
            _circle = new Circle(x, y, radius);
            _height = height;
        }
        public Cylinder(Circle a)
        {
            _circle = new Circle(a);
            _height = 1;
        }
        public Cylinder(Cylinder a)
        {
            _circle = new Circle(a._circle.Center.X, a._circle.Center.Y, a._circle.Radius);
            _height = a.Height;
        }
        public override double getArea()
        {
            return (2 * Math.PI * _circle.Radius * Height) + (2 * _circle.getArea());
        }
        public double getVolume()
        {
            return _circle.getArea() * Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", _circle.Center, _circle.Radius, Height, getArea(), getVolume());
        }
    }
}

