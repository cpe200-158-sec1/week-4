using System;

namespace Lab402
{
	public class Triangle : Shape
	{
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }

        public Triangle()
        {
            _width = 1.0;
            _height = 1.0;
            _color = "gold";
        }

        public Triangle(string clr1, double w1, double h1)
        {
            _color = clr1;
            _width = w1;
            _height = h1;
        }

        public Triangle(Rectangle cpy)
        {
            _width = cpy.Width;
            _height = cpy.Height;
            _color = cpy.Color;
        }

        public override string Color
        {
            get
            {
                return _color;
            }
        }

        public override double getArea()
        {
            return (0.5 * _width * _height);
        }

        public override double getPerimeter()
        {
            return (_width + _height + (Math.Sqrt((_width * _width) + (_height * _height))));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }
    }
}

