using System;

namespace Lab4
{
	public class Triangle:Shape
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
        public Triangle(string a)
        {
            _Color = a;
            _Height = 1.0;
            _Width = 1.0;
        }

        public Triangle()
        {
            _Color = "gold";
            _Height = 1.0;
            _Width = 1.0;
        }
        public Triangle(string c, double w, double h)
        {
            _Color = c;
            _Height = h;
            _Width = w;
        }

        public Triangle(Rectangle a)
        {
            _Color = a.Color;
            _Height = a._Height;
            _Width = a._Width;
        }

        public override double getArea()
        {
            return 0.5*_Height*_Width;
        }

        public override double Perimeter()
        {
            return  Math.Sqrt(Math.Pow(_Width, 2) + Math.Pow(_Height, 2))+ _Width + _Height;
        }

        public override string ToString()
        {
            string output;
            output = "[Triangle: base=" + _Width + ", height=" + _Height + ", area=" + getArea() + ", color=" + _Color + "]";

            return output;
        }

    }

}

