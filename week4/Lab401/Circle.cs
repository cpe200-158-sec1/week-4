using System;

namespace Lab4
{
	public class Circle
    {
        //## Properties:
        //- Point Center: a point represent the center of a circle(use Point class)
        //- double Radius: radius of a circle(>=0, default=1.0)
        public Point P;
        public double pi = Math.PI;
        private double _r;
        public double Radius
        {
            get { return _r; }
            set { _r = value ; }
        }
        //## Constructors:
            //- Circle(double) : takes radius as a paramenter
            //- Circle(double, double, double) : takes x, y, radius as parameters
            //- Circle(Circle) : copy constructor
        public Circle(double r=1)
        {
            P = new Point();
            Radius = r;
        }
        public Circle(double x,double y,double r = 1)
        {
            P = new Point(x,y);
            Radius = r;
        }
        public Circle(Circle c)
        {
            P = new Point(c.P);
            Radius = c.Radius;
        }
        //## Methods:
        //- setCircle(double, double, double): take x, y, radius as parameters
        //- getArea(): virtual, get area of a cicle
        //- override ToString() method
        public void setCircle(double x,double y,double r)
        {
            P = new Point(x, y);
            Radius = r;
        }
        private double getArea()
        {
            return pi * Radius * Radius;
        }
        public override string ToString()
        {
            //[Circle: center(1.5,5), radius=2, area=12.5663706143592]
            return "[Circle: "+P+", readius="+Radius+",area="+getArea()+"]";
        }
    }
}

