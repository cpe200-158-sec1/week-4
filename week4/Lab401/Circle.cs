using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = (value >= 0) ? value : 1; }
        }
        public Circle()
        {
           Radius = 1.0;
            x = 0.0;
            y = 0.0;
        }
        public Circle(double a)
        {
            Radius = a;
            x = 0.0;
            y = 0.0;
        }
        public Circle(double a, double b, double c)
        {
            Radius = c;
            x = a;
            y = b;
        }
        public Circle(Circle a)
        {
            Radius = a.Radius;
            x = a.x;
            y = a.y;
        }
        public void setCircle(double a, double b, double c)
        {
            this.Radius = c;
            this.x = a;
            this.y = b;
        }
        public virtual double getArea()
        {
            return  ((22.0 / 7.0) * this.Radius * this.Radius);
        }
        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.x,this.y, this.Radius,getArea());
        }
    }
}

