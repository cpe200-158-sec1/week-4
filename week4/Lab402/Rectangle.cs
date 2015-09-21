using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width, _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(value <= 0)
                {
                    _width = 1.0;
                }
                else
                {
                    _width = value;
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
                if (value <= 0)
                {
                    _height = 1.0;
                }
                else
                {
                    _height = value;
                }
            }
        }
        public Rectangle()
		{
            Width = 1;
            Height = 1;
		}
        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(Rectangle a) : base(a.Color)
        {
            Width = a.Width;
            Height = a.Height;
        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return (Width * 2) + (Height * 2);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width = {0}, height = {1}, area = {2}, color = \"{3}\"]", Width, Height, getArea(), this.Color);
        }
    }
}

