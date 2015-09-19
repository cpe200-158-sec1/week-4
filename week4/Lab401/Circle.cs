using System;

namespace Lab4
{
	public class Circle : Point
	{
        public Point _Center=new Point();
        private double _Radius;

        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                }
                else
                {
                    _Radius = 1.0;
                }
            }
        }
		public Circle ()
		{
            _Radius = 1.0;
		}
        public Circle (double r)
        {
            Radius = r;
        }
        public Circle (double xx,double yy,double r)
        {
            _Radius = r;      
            _Center.x = xx;
            _Center.y = yy;
        }
        public Circle(Circle a)
        {
            Radius = a.Radius;
            _Center.x = a._Center.x;
            _Center.y = a._Center.y;

        }
        //method
        public void SetCircle(double xx, double yy, double r)
        {
            Radius = r;
            _Center.x = xx;
            _Center.y = yy;
        }
        public virtual double getArea()
        {
            double area;
            area = Math.Pow(_Radius,2)*Math.PI;
            return area;
        }
        // [Circle: center(0, 0), radius=1, area=3.14159265358979]

        public override string ToString()
        {
            string output = ("[Circle: center("+_Center.x+", "+_Center.y+"), radius="+Radius+", area="+getArea()"]");
            return output;
        }
    }
}

