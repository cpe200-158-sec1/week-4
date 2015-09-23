using System;

namespace Lab4
{
    public class Circle : Point 
    {
        //- double Radius: radius of a circle(>=0, default=1.0)
        //        - Circle() : default
        //- Circle(double) : takes radius as a paramenter
        //- Circle(double, double, double) : takes x, y, radius as parameters
        //- Circle(Circle) : copy constructor
        private double _Radius;
        private Point _XY;
        public Circle()
        {
            _XY = new Point();
            _Radius = 1.0;
        }
        public Circle(double r)
        {
            _XY = new Point();
            if (r < 0)
                _Radius = 1.0;
            else
                _Radius = r;
        }
        public Circle(double x, double y, double radius)
        {
            _XY = new Point(x, y);
            _Radius = radius;
        }
        public Circle(Circle a)
        {
            _XY = new Point(a._XY);
              
            _Radius = a._Radius;
        }
        public Point XY
        {
            get { return _XY; }
            set { _XY = value; }
           
        }
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        //        - setCircle(double, double, double): take x, y, radius as parameters
        //- getArea(): virtual, get area of a cicle
        //- override ToString() method
        public void setCircle(double X, double Y, double radius)
        {
            x = X;
            y = Y;
            if (radius < 0)
                _Radius = 1.0;
           else
                _Radius = radius;
        }
        public virtual double getArea()
        {
            return (1.00 * Math.PI * _Radius * _Radius);
        }
        public override string ToString()
        {
            // [Circle: center(0, 0), radius=1, area=3.14159265358979]
            return string.Format("[Circle: {0}, radius={1}, area={2}]",_XY, _Radius, getArea());
        }
    }
}

