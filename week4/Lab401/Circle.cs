using System;

namespace Lab4
{
	public class Circle
	{
        private Point _center;
        private double _radius;

        public Point center
        {
            get
            {
                return _center;
            }
           
        }
        public double radius
        {
            get
            {
                return _radius;
            }
            set
            {

                if(value <0)
                {
                    _radius = 0;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public Circle ()
		{
            _center = new Point();
            _radius = 1.0;
		}

        public Circle(double r)
        {
            _center = new Point();
            _radius = r;
        }

        public Circle(double x, double y, double r)
        {
            _center = new Point(x,y);
            _radius = r;
        }

        public Circle(Circle c)
        {
            _center = c.center;
            _radius = c.radius;
        }

        public void setCircle(double x, double y, double r)
        {
            _center = new Point(x, y);
            _radius = r;
        }

        public  double getArea()
        {
            double area;
            area = Math.PI*_radius*_radius;
            return area;
        }

        public override string ToString()
        {
            //[Circle: center(0,0), radius=1, area=3.14159265358979]
            string outputstring = "[Circle: center(";
            outputstring += center.x + "," + center.y + "), radius=" + _radius + ", area=" + getArea() + "]";
            return outputstring;
        }
    }
}

