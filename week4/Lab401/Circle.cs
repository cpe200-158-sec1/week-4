using System;

namespace Lab4
{
	public class Circle : Point
	{
        protected double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (_radius >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1.0;
                }
            }
        }


        public Circle ()
		{
            _radius = 1.0;
		}

        public Circle(double r1)
        {
            _radius = r1;
        }

        public Circle(double x2,double y2,double r2)
        {
            _x = x2;
            _y = y2;
            _radius = r2;
        }

        public Circle(Circle cpy)
        {
            _x = cpy.X;
            _y = cpy.Y;
            _radius = cpy.Radius;
        }

        public void setCircle(double x3,double y3,double r3)
        {
            _x = x3;
            _y = y3;
            _radius = r3;
        }

        public double getArea()
        {
            return ((Math.PI) * _radius * _radius) ;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center=({0},{1}), radius={2}, area={3}]" , X , Y , Radius, getArea());
        }
    }
}

