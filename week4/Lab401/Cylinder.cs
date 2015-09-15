using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _Height;
        public double height
        {
            get { return _Height; }
            set { _Height = (value >= 0) ? value : 1.0; }
        }
		public Cylinder ()
		{
            x = 0;
            y = 0;
            radius = 1.0;
            height = 1.0;
		}
        public Cylinder(double r,double h)
        {
            x = 0;
            y = 0;
            radius = r;
            height = h;
        }
        public Cylinder(double a,double b,double r,double h)
        {
            x = a;
            y = b;
            radius = r;
            height = h;
        }
        public Cylinder(Circle a)
        {
            x = a.x;
            y = a.y;
            radius = a.radius;
            height = 1.0;
        }
        public Cylinder(Cylinder a)
        {
            x = a.x;
            y = a.y;
            radius = a.radius;
            height = a.height;
        }
        public override double getArea() // getSurface
        {
            return (2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius);
        }
        public double getVolume()
        {
            return Math.PI * radius * radius * height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.x, this.y, this.radius, this.height, this.getArea(), this.getVolume());
        }
    }
}

