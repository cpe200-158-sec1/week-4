using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
        private Circle _circle; 
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    _height = 1.0;
                else
                    _height = value;
            }
        }

        public Cylinder ()
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
        public Cylinder(Circle obj)
        {
            _circle = new Circle(obj);
            _height = 1;
        }
        public Cylinder(Cylinder obj)
        {
            _circle = new Circle(obj._circle.Center.X,obj._circle.Center.Y,obj._circle.Radius);
            _height = obj.Height;
        }

        public override double getArea()
        {
           return (2 * Math.PI * _circle.Radius * Height) +( 2 * _circle.getArea());
        }
        public double getVolume()
        {
           return  _circle.getArea() * Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", _circle.Center.X, _circle.Center.Y, _circle.Radius, Height, getArea(), getVolume());
        }
    }
}

