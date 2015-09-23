using System;

namespace Lab4
{
	public class Triangle : Shape  
	{
        private double _Width;
        private double _Height;

        public double Width
        {
            get { return _Width; }
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
            get { return _Height; }
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

        public Triangle ()
		{
            Width = 1.0;
            Height = 1.0;
        }

        public Triangle(string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;

        }

        public Triangle (Rectangle a)
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
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}



