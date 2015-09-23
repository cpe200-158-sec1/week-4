using System;

namespace Lab4
{
	    public class Circle : Point {
        public double redius;
        public Point _pointcenter=new Point();

        
        public Circle()
        {
            redius = 1.0;
            
        }

        public Circle(double r)
        {
            redius =r;
        }

        public Circle(double x,double y, double r)
        {
            _pointcenter.x = x;
            _pointcenter.y = y;
            redius = r;
        }

        public Circle(Circle a)
        {
            _pointcenter.x = a._pointcenter.x;
            _pointcenter.y = a.y;
            redius = a.redius;
        }

        public void setCircle(double x,double y,double r)
        {
            _pointcenter.x = x;
            _pointcenter.y = y;
            redius = r;
            
        }
        public virtual double getArea()
        {
            double area;
            area = (Math.PI * (redius * redius));
            return area;
        }


        public override string ToString()
        {
            string output;
            output = ("[Cycle: center(" + _pointcenter.x + "," + _pointcenter.y + "), radius=" + redius + ", area=" + getArea()+ "]");
            return output;
        }
    }
}

