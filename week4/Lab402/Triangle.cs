using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width;
        private double _height;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0) _width = value;
                else _width = 1.0;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0) _height = value;
                else _height = 1.0;
            }
        }

		public Triangle ()
		{
            Width = 1.0;
            Height = 1.0;
		}
        public Triangle (string pColor, double pWidth, double pHeight) : base(pColor)
        {
            Width = pWidth;
            Height = pHeight;
        }
        public Triangle (Triangle pTriangle) : base(pTriangle.Color)
        {
            Width = pTriangle.Width;
            Height = pTriangle.Height;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
    }
}

