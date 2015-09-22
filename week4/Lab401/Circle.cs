using System;

namespace Lab4
{
	public class Circle
	{
        private Point _center;
        private double _radius;
        public Point Center
        {
            get;
            set;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1;
                }
            }
        }

        public Circle ()
		{
            Center = new Point();
            Radius = 1.0;
		}
        public Circle (double pRadius)
        {
            Center = new Point();
            Radius = pRadius;
        }
        public Circle (double pX, double pY, double pRadius)
        {
            Center = new Point(pX, pY);
            Radius = pRadius;
        }
        public Circle (Circle pCircle)
        {
            Center = new Point(pCircle.Center);
            Radius = pCircle.Radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center{0}, radius={1}, area={2}]", Center, Radius, getArea());
        }
        public void setCircle(double pX, double pY, double pRadius)
        {
            Center = new Point(pX, pY);
            Radius = pRadius;
        }
        public virtual double getArea()
        {
            double pi = Math.PI;
            return (pi * Radius * Radius);
        }
	}
}

