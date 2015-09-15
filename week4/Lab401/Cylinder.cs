using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set { _Height = (value >= 0) ? value : 1.0; }
        }
        public Cylinder ()
		{
            Height = 1.0;
            Radius = 1.0;
            x = 0.0;
            y = 0.0;
		}
        public Cylinder(double a, double b)
        {
            Height = b;
            Radius = a;
            x = 0.0;
            y = 0.0;
        }
        public Cylinder(double a, double b, double c, double d)
        {
            Height = d;
            Radius = c;
            x = a;
            y = b;
        }
        public Cylinder(Circle a)
        {
            Height = 1;
            Radius = a.Radius;
            x = a.x;
            y = a.y;
        }
        public Cylinder(Cylinder a)
        {
            Height = a.Height;
            Radius = a.Radius;
            x = a.x;
            y = a.y;
        }
        public override double getArea()
        {
            return 2.0*(22.0/7.0)*Radius + (Height * Radius * 2.0 * (double)(22.0 / 7.0));
        }
        public double getVolume()
        {
            return (22.0/7.0)*Radius*Radius*Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.x, this.y,this.Radius,this.Height,getArea(),getVolume());
        }
    }
}

