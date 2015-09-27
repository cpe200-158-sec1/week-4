using System;

namespace Lab4
{
	public class Triangle : Shape
    {
        private double _width, _height;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
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
                if (value < 0)
                    _height = 1;
                else
                    _height = value;
            }
        }

        public Triangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }

        public Triangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public Triangle(Rectangle obj) : base(obj.Color)
        {
            Width = obj.Width;
            Height = obj.Height;
        }

        public override double getArea()
        {
            return 0.5 * Width * Height;
        }

        public override double getPerimeter()
        {
            return Width + (2 * Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), this.Color);
        }
    }
}

