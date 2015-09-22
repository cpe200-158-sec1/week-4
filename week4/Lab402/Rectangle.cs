using System;

namespace Lab4
{
	public class Rectangle : Shape
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
        
		public Rectangle ()
		{
            Width = 1.0;
            Height = 1.0;
		}
        public Rectangle (string pColor, double pWidth, double pHeight) : base(pColor)
        {
            Width = pWidth;
            Height = pHeight;
        }
        public Rectangle (Rectangle pRectangle) : base(pRectangle.Color)
        {
            Width = pRectangle.Width;
            Height = pRectangle.Height;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return 2.0 * (Width + Height);
        }
    }
}

