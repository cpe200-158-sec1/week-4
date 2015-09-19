using System;

namespace Lab4
{
	public class Cylinder:Circle
	{
        public Circle _circle=new Circle();
        public double _Height;
     
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value < 0)
                {
                    value = 1.0;
                }
                _Height = value;
            }
        }
		public Cylinder ()
		{
            _Height = 1;
		}
        public Cylinder(double r,double h)
        {
            _circle.Radius = r;
            _Height = h;
        }
        public Cylinder(double xx,double yy,double r,double h)
        {
            _circle.Radius = r;
            _circle._Center.x = xx;
            _circle._Center.y = yy;
            _Height = h;
        }
        public Cylinder(Circle a)
        {
            _circle._Center.x = a._Center.x ;
            _circle._Center.y = a._Center.y;
            _circle.Radius = a.Radius;
            _Height = 1;
        }
        public Cylinder(Cylinder a)
        {
            _circle._Center.x = a._circle._Center.x;
            _circle._Center.y = a._circle._Center.y;
            _Height = a.Height;
            _circle.Radius = a._circle.Radius;
        }

        //method
        public override double getArea()
        {
            double area;
            area = (2*Math.PI * Math.Pow(_circle.Radius, 2))+(2*Math.PI*_circle.Radius*Height);
            return area;
        } 
        public double getVolume()
        {
            double volume;
            volume = Math.PI * Math.Pow(_circle.Radius, 2) * Height;
            return volume;
        }
        //[Cylinder: center(1.5, 5), radius=2, height=1, surface=37.6991118430775, volume=12.5663706143592]
        public override string ToString()
        {
            string output= ("[Cylinder: center(" + _circle._Center.x + ", " + _circle._Center.y + "), radius=" + _circle.Radius + ",Height="+Height+", Surface=" + getArea()+", volume="+getVolume()"]");
            return output;
        }
    }
}

