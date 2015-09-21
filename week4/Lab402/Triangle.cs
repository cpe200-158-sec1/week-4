using System;

namespace Lab4
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
                if (value <= 0)
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
        public Triangle()
        {
            Width = 1;
            Height = 1;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Triangle(Rectangle a) : base(a.Color)
        {
            Width = a.Width;
            Height = a.Height;
        }
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Width + Height + (Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base = {0}, height = {1}, area = {2}, color = \"{3}\"", Width, Height, getArea(), this.Color);
        }
    }
}

