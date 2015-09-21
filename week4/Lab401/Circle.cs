using System;

namespace Lab4
{
    public class Circle : Point
    {
        private Point _center;
        private double _radius;

        public override string ToString()
        {
            return  string.Format("Circle: center=({0},{1}), radius={2}, area={3},", x, y, radius, getArea());
        }
        public double radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Point center
        {
            get { return _center; }
            set { _center = value; }
        }
        public Circle() : base()
        {
           
            _radius = 1;

        }

        public Circle(Circle a)
        {

            _radius = a.radius;

        }
        public Circle(double r)
        {
            _radius = r;
        }
        public Circle(double x, double y, double r)
        {
            _center = new Point(x, y);
            _radius = r;
        }

        public void setCircle(double x, double y, double radius)
        {
            this._center = new Point(x, y);
            this._radius = radius;
        }
        public  double getArea()
        {
            return (double)(3.14159265358979 * _radius * _radius);
       }
      
}
}

