using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _Radius;
        public double Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = (value >= 0) ? value : 0;
            }
        }
		public Circle () :base(0,0) // this is use base 
		{
            Radius = 1.0;
		}

        public Circle (double c)
        {
            // can use base to easy to use function
            x = 0;
            y = 0;
            Radius = c;
        }

        public Circle (double xx ,double yy ,double cc)
        {
            x = xx;
            y = yy;
            Radius = cc;
        }

        public Circle (Circle ci) 
        {
            x = ci.x;
            y = ci.y;
            Radius = ci.Radius;
        }

        public void setCircle (double scx,double scy,double csr) : base (scx,scy)
        {
            Radius = csr;
        }

        public virtual double getArea ()
        {
            return Math.PI * Radius * Radius; 
        }

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius ={2}, area ={3}",this.x,this.y,this.Radius,this.getArea());
        }
    }
}

