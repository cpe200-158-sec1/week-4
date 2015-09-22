using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _Height;

        public double Height
        {
            get { return _Height; }
            set
            {
                if ( value >= 0 )
                {
                    _Height = value;
                }

                else
                {
                    _Height = 1.0;
                }
            }
        }

        public Cylinder ():base()
		{
            _Height = 1.0;
            
        }

        public Cylinder (double r , double h) : base(r)
        {
            _Height = h;
        }

        public Cylinder (double a , double b , double r , double h) : base(a,b,r)
        {
            _Height = h;
        }

        public Cylinder (Circle c) : base(c)
        {
            _Height = 1.0;
        }

        public Cylinder (Cylinder cd) 
        {
            x = cd.x;
            y = cd.y;
            Radius = cd.Radius;
            _Height = cd._Height;
        }

        public override double getArea()
        {
            return 2*Math.PI*Radius*Height+2*Math.PI*Radius*Radius;
        }

        public double getVolume()
        {
            return Math.PI*Radius*Radius*Height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]" , x , y , Radius , Height , getArea() , getVolume());
        }
    }
}

