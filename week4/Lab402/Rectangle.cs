using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
        public double _Width;
        public double _Height;

        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1.0;
                }
            }
        }
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1.0;
                }
            }
        }


        public Rectangle ()
		{
            _Height = 1.0;
            _Width = 1.0;
		}
        public Rectangle(string c,double w,double h) 
        {
            _Color = c;
            _Height = h;
            _Width = w;
        }

        public Rectangle(Rectangle a)
        {
            _Color = a._Color;
            _Height = a._Height;
            _Width = a._Width;
        }

        public override double getArea()
        {
            return _Height * _Width;
        }

        public override double Perimeter()
        {
            return 2 * (_Width + _Height);
        }

        public override string ToString()
        {
            string output;
            output = "[Rectangle: width=" + _Width + ", height=" + _Height + ", area=" + getArea() + ", color=" + _Color + "]";

            return output;
        }

    }

}
/*
[Rectangle: width=4, height=5, area=20, color="red"]
[Triangle: base=4, height=5, area=10, color="blue"]
[Rectangle: width=1, height=1, area=1, color="gold"]
[Rectangle: width=4, height=5, area=20, color="red"]
Perimeter s1: 18
Perimeter s1: 15.4031242374328
Perimeter s1: 4
Perimeter s1: 32
Perimeter s1: 12*/
