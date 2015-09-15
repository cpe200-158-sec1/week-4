using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double Height;
        public double height
        {
            get { return Height; }
            set { Height = value; }
        }
		public Cylinder()
		{
            x = 0;
            y = 0;
            radius = 1.0;
            height = 1.0;
		}
        public Cylinder(double r, double h)
        {
            x = 0.0;
            y = 0.0;
            radius = r;
            height = h;
        }
        public Cylinder(double a, double b, double r, double h)
        {
            x = a;
            y = b;
            radius = r;
            height = h;
        }
        public Cylinder(Circle c)
        {
            x = c.x;
            y = c.y;
            radius = c.radius;
            height = 1.0;
        }
        public Cylinder(Cylinder c)
        {
            x = c.x;
            y = c.y;
            radius = c.radius;
            height = c.height;
        }
        public override double getArea()
        {
            return 2*Math.PI * radius * radius+2*Math.PI*radius*height;
        }
        public double getVolume()
        {
            return Math.PI * radius * radius * height;
        }
        public override string ToString()
        {
            return String.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.x, this.y, this.radius, this.height, this.getArea(), this.getVolume());
        }
    }
}

