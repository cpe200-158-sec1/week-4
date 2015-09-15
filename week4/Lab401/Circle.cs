using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _radius;
        public double radius
        {
            get { return _radius; }
            set { _radius = (value >= 0) ? value : 1.0; }
        }
        public Circle () : base(0,0)
        {
            radius = 1.0;
        }
		public Circle (double a)
		{
            x = 0;
            y = 0;
            radius = a;
		}
        public Circle (double a,double b, double c)
        {
            x = a;
            y = b;
            radius = c;
        }
        public Circle(Circle a)
        {
            x = a.x;
            y = a.y;
            radius = a.radius;
        }
        public void setCircle (double a, double b, double c)
        {
            x = a;
            y = b;
            radius = c;
        }
        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return String.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.x, this.y, this.radius, this.getArea());
        }
    }
}

