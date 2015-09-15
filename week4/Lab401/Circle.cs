using System;

namespace Lab4
{
	public class Circle 
	{
        private Point _Center;
        public Point Center
        {
            get { return _Center; }
        }
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value < 0)
                {
                    _Radius = 1;
                }
                else
                {
                    _Radius = value;
                }

            }
        }

        public Circle()
        {
            _Center = new Point();
            _Radius = 1.0;
        }
        public Circle(double r)
        {
            _Center = new Point();
            _Radius = r;
        }
        public Circle(double x, double y, double r)
        {
            _Center = new Point(x, y);
            _Radius = r;
        }
        public Circle(Circle c)
        {
            _Center = c.Center;
            _Radius = c.Radius;

        }
        public void setCircle(double x, double y, double r)
        {
            _Center = new Point(x, y);
            _Radius = r;           
        }
        public double getArea()
        {
            return Math.PI * _Radius * _Radius;
        }

        //Tostring
        public override string ToString()
        {
            string s = "[Circle: center("+Center.x+","+Center.y+") ,radius="+_Radius+" , area="+getArea()+"]";
            return s;
        }

    }
}

