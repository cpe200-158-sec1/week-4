using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        protected double _height;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height >= 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }

        public Cylinder () :base()
		{
            _height = 1.0;
		}

        public Cylinder(double r4, double h1) 
        {
            _radius = r4;
            _height = h1;
        }

        public Cylinder(double x, double y, double r, double h)
        {
            _height = h;
            _radius = r;
            _x = x;
            _y = y;
        }

        public Cylinder(Circle cpy)
        {
            _x = cpy.X;
            _y = cpy.Y;
            _height = 1.0;
            _radius = cpy.Radius;
        }

        public Cylinder(Cylinder cc)
        {
            _x = cc.X;
            _y = cc.Y;
            _radius = cc.Radius;
            _height = cc.Height;
        }

        public double getSurface()
        {
            return (2 * (Math.PI) * _radius * _height + 2 * (22/7) * _radius * _radius);
        }

        public double getVolume()
        {
            return ((Math.PI) * _radius * _radius * _height);
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center=({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]" , _x, _y, _radius, _height, getSurface(), getVolume());
        }
    }
}

