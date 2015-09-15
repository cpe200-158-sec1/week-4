using System;

namespace Lab4
{
	public class Circle : Point
	{
       
        private double _Radius;

        public Circle () : base()
		{
           
            _Radius = 1;
		}

        public Circle (double r) : base()
        {
            _Radius = r;
        }

        public Circle ( double a , double b , double r) : base(a,b)
        {
            _Radius = r;
        }

        public Circle(Circle cc) : base(cc.x , cc.y)
        {
            _Radius = cc._Radius;
        }

        public double Radius
        {
            get { return _Radius; }
            set
            {
                if ( value >= 0 )
                {
                    _Radius = value;
                }
                else
                {
                    _Radius = 1;
                }
            }
        }

        public void setCircle(double a, double b, double r)
        {
            x = a;
            y = b;
            _Radius = r;
        }

        public virtual double getArea()
        {
            double area;
            area = Math.PI * _Radius * _Radius; 
            return area;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]" , x , y , _Radius , getArea() );
        }

    }
}

