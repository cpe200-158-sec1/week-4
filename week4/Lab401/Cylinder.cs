using System;

namespace Lab4
{
	public class Cylinder : Circle 
	{
        private double _Height;
        public double Height{
            get { return _Height; }
            set
            {
                if(value < 0)
                {
                    _Height = 1.0;
                }
                else {
                    _Height = value;
                }
            }
        }
        Circle c = new Circle();



        public Cylinder ()
		{
            _Height = 1.0;
		}

        public Cylinder(double r, double h) {
            c.Radius = r;
            _Height = h;
        }
        public Cylinder(double x, double y, double r, double h)
        {
            c = new Circle(x, y, r);
            _Height = h;
        }
        public Cylinder(Circle c)
        {
            this.c = c;
            _Height = 1.0;
        }
        public Cylinder(Cylinder cy)
        {
            c = cy.c;
            _Height = cy._Height;
        }

        public virtual double getArea()
        {
            return (2*Math.PI*c.Radius*_Height)+(2*Math.PI*c.Radius*c.Radius);
        }
        public double getVolume()
        {
            return (Math.PI * c.Radius * c.Radius * _Height);
        }

        //Tostring
        public override string ToString()
        {
            string s = "[Cylinder: center(" + c.Center.x+","+c.Center.y+") ,radius=" + c.Radius + " , height=" + _Height + ", surfact="+getArea()+", volume="+getVolume()+"]";
            return s;
        }
    }
}

