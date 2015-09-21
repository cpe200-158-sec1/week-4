using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _h;
        public double Height
        {
            get { return _h; }
            set { _h = value; }
        }
		public Cylinder ()
		{
            Height = 1.0;
		}
        public Cylinder (double r, double h)
        {
            X = 0;
            Y = 0;
            Radius = r;
            Height = h;
        }
        public Cylinder (double x, double y, double r, double h)
        {
            X = x;
            Y = y;
            Radius = r;
            Height = h;
        }
        public Cylinder (Circle a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
            Height = 1.0;
        }
        public Cylinder (Cylinder a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
            Height = a.Height;
        }
        public override double getArea()
        {
            return 2 * Math.PI * Radius * Height + 2 * Math.PI * Radius * Radius;
        }
        public double getVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
        public override string ToString()
        {
            return String.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.X, this.Y, this.Radius, this.Height, this.getArea(), this.getVolume());
        }
    }   
}

