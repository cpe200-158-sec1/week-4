using System;

namespace Lab4
{
    public class Circle : Point
    {
        //## Properties
        private Point _Center;
        private double _Radius;

        public Point Center
        {
            get { return _Center; }
            set
            { _Center = value; }
        }
        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 1)
                    _Radius = value;
                else _Radius = 1.0;
            }
        }

        //## Constructors
        public Circle()
        {
            Center = new Point();
            Radius = 1.0;
        }
        public Circle(double radius)
        {
            Center = new Point();
            Radius = radius;
        }
        public Circle(double a, double b, double radius)
        {
            Center = new Point(a, b);
            Radius = radius;
        }
        public Circle(Circle c)
        {
            Center = new Point(c.Center);
            Radius = c.Radius;
        }
        //## Methods
        public void setCircle(double a, double b, double radius)
        {
            Center = new Point(a, b);
            Radius = radius;
        }
        public double getAreaCircle()
        {
            return (Math.PI * Radius * Radius);
        }
        public override string ToString()
        {
            return string.Format("[Circle: center({0}), radius={1}, area={2}]", Center, Radius, getAreaCircle());
        }
    }
}







