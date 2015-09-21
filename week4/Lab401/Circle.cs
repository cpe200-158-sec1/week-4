using System;

namespace Lab4
{
	public class Circle :Point
	{
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
		public Circle ()
		{
            X = 0;
            Y = 0;
            Radius = 1.0;
		}
        public Circle (double c )
        {
            Radius = c;
        }
        public Circle (double x, double y, double z)
        {
            X = x;
            Y = y;
            Radius = z;
        }
        public Circle (Circle c)
        {
            X = c.X;
            Y = c.Y;
            Radius = c._radius;
        }
        public void setCircle(double x, double y,double z)
        {
            X = x;
            Y = y;
            Radius = z;
        }
        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        } 
        public override string ToString()
        {
            return String.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.X, this.Y, this.Radius, this.getArea());
        }
    }
}

