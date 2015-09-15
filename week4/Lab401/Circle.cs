using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double Radius;
        public double radius
        {
            get { return Radius; }
            set { Radius = value; }
        }
		public Circle()
		{
            x = 0.0;
            y = 0.0;
            radius = 1.0;
		}
        public Circle(double r)
        {
            radius = r;
        }
        public Circle(double a, double b, double r)
        {
            x = a;
            y = b;
            radius = r;
        }
        public Circle(Circle c)
        {
            x = c.x;
            y = c.y;
            radius = c.radius;
        }
        public void setCircle(double a, double b, double r)
        {
            x = a;
            y = b;
            radius = r;
        }
        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return String.Format("[Circle: center({0},{1}), radius={2}, area={3}", this.x, this.y, this.radius, this.getArea());
        }
    }
}

