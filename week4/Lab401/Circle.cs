using System;

namespace Lab401
{
	public class Circle
	{
        public Point C;
        public double pi = Math.PI;
        private double _r;

        public double R
        {
           get { return _r; }
           set { _r = value; } 
        }

       
        public Circle(double r = 1)
        {
            C = new Point();
            R = r;
        }
        public Circle(double x, double y, double r = 1)
        {
            C = new Point(x, y);
            R = r;
        }
        public Circle(Circle c)
        {
            C = new Point(c.C);
            R = c.R;
        }
        public void setCircle(double x, double y, double r)
        {
            C = new Point(x, y);
            R = r;
        }
        private double getArea()
        {
            return pi * R * R;
        }
        public override string ToString()
        {
            //[Circle: center(1.5,5), radius=2, area=12.5663706143592]
            return "[Circle: " + C + ", readius=" + R + ",area=" + getArea() + "]";
        }
    }
}


