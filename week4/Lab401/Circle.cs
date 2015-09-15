using System;
/*# 2. Circle Class:
## Properties:
- Point Center: a point represent the center of a circle (use Point class)
- double Radius: radius of a circle (>=0, default=1.0)

## Constructors:
- Circle(): default
- Circle(double): takes radius as a paramenter
- Circle(double, double, double): takes x,y,radius as parameters
- Circle(Circle): copy constructor

## Methods:
- setCircle(double,double,double): take x,y,radius as parameters
- getArea(): virtual, get area of a cicle
- override ToString() method*/
namespace Lab4

{

    public class Circle : Point
    {
        private Point _center;
        private double _radius;

        public Point Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        //constructor
        public Circle()
        {
            _center = new Point();
            _radius = 1;
        }

        public Circle(double r)
        {
            _center = new Point();
            _radius = r;
        }

        public Circle(double x, double y, double r)
        {
            _center = new Point(x, y);
            _radius = r;
        }

        public Circle(Circle C)
        {
            _center = new Point(C.Center);
            _radius = C.Radius;
        }

        //methods
        public void setCircle(double x, double y, double r)
        {
            _center = new Point(x, y);
            _radius = r;
        }
        public double getArea()
        {
            return Math.PI * _radius * _radius;
        }
        public override string ToString()
        {
            return string.Format("[Circle: center{0}, radius={1}, area = {2}]", _center, _radius, getArea());
        }



    }
}

