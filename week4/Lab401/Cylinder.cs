using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
       
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
           _height = 1;
		}
        public Cylinder(double radius, double height) : base(radius)
        {
           _height = height;
        }
        public Cylinder(double x, double y, double radius, double height) : base(x, y, radius)
        {
            _height = height;
        }
        public Cylinder(Circle obj) : base(obj)
        {
            _height = 1;
        }
        public Cylinder(Cylinder obj) : base(obj.Center.X,obj.Center.Y,obj.Radius)
        {
            _height = obj.Height;
        }

        public override double getArea()
        {
           return (2 * Math.PI * this.Radius * Height) +( 2 * base.getArea());
        }
        public double getVolume()
        {
           return base.getArea() * Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.Center.X, this.Center.Y,this.Radius, Height, getArea(), getVolume());
        }
    }
}

