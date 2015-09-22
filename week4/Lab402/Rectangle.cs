using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width;
        private double _height;
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", _width, _height, getArea(), _color);
        }
        public Rectangle()
		{
            _width = 1;
            _height = 1;
            _color = "gold";
		}
        public Rectangle(String color, double width, double height)
        {
            _color = color;
            _width = width;
            _height = height;
        }
        public Rectangle(Rectangle obj)
        {
            _color = obj._color;
            _width = obj.Width;
            _height = obj.Height;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    _width = 1;
                else
                    _width = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    _height = 1;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public override double getArea()
        {
            return _width * _height;
        }
        public override double getPerimeter()
        {
            return 2 * (_width + _height);
        }

    }
}

