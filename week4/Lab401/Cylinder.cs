using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
        Circle c = new Circle();
        
        public double height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }


        public Cylinder ()
		{

            c = new Circle();
            _height = 1.0;
		}

        public Cylinder(double r, double h)
        {
            c.radius = r;
            _height = h;
        }

        public Cylinder(double x, double y , double r, double h)
        {
            c = new Circle(x,y, r);
            _height = h;
        }

        public Cylinder(Circle c)
        {
            this.c = c;
            _height = 1.0;
        }

        public Cylinder(Cylinder inputcylinder)
        {
            c = new Circle(inputcylinder.c);
            _height = inputcylinder.height;
        }

         new public  double getArea()
        {
            return c.getArea()*2 + (_height*c.radius*2*Math.PI);
        }

        public double getVolume()
        {
            return c.getArea() * _height;
        }

        public override string ToString()
        {
            //[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
            string outputstring = "[Cylinder: center(";
            outputstring += c.center.x + "," + c.center.y + "), radius=" + c.radius + ", height=" + _height + ", surface=" + getArea() + ", volume=" + getVolume()+"]";
            return outputstring;
        }
    }
}

