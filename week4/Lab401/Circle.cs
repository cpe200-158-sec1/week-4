using System;
using Lab4;
namespace Lab4
{
    public class Circle 
    {
        private Point _center = new Point();
        private double _radius;

        public Point Center
        {
            get
            {
                return _center;
            }
            set
            {
                _center = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 1)
                {
                    _radius = value;
                }
                else _radius = 1;
            }
        }
        public Circle()
        {
            Center.X = 0;
            Center.Y = 0;
            Radius = 1;
        }

        public Circle(double a)
        {
            Center.X = 0;
            Center.Y = 0;
            Radius = a;
        }

        public Circle(double a, double b, double c)
        {
            Center.X = a; // this.X is false . // this.Center.X is true
            Center.Y = b;
            Radius = c;
        }

        public Circle(Circle a)
        {
            this.Center = a.Center;
            this.Radius = a.Radius;
        }

        public void setCircle(double a, double b, double c)
        {
            Center.X = a;
            Center.Y = b;
            Radius = c;
        }

        public double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle:{0}, radius={1}, area={2}]", Center, Radius, getArea());
        }


    }
}

