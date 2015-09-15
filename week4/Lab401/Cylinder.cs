using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
        
        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = (value >= 0) ? value : 0 ;           
            }
        }
    
		public Cylinder ()
		{
            x = 0;
            y = 0;
            Radius = 1;
            height = 1;
		}
        public Cylinder(double ra,double he)
        {
            x = 0;
            y = 0;
            Radius = ra;
            height = he;
        }
        public Cylinder(double cyx,double cyy,double cyra,double cyhe ) 
        {
            x = cyx;
            y = cyy;
            Radius = cyra;
            height = cyhe;
        }
        public Cylinder(Circle cir)
        {
            x = cir.x;
            y = cir.y;
            Radius = cir.Radius;
            height = 1;
        }
        public Cylinder(Cylinder Cyl)
        {
            x = Cyl.x;
            y = Cyl.y;
            Radius = Cyl.Radius;
            height = Cyl.height;
        }

        public override double getArea()
        {
            return (2 * Math.PI * Radius * height) + (2 * Math.PI * Radius * Radius);
        }

        public double getVolume()
        {
            return Math.PI * Radius * Radius * height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.x, this.y, this.Radius,this.height, this.getArea(), this.getVolume());
        }
    }
}

