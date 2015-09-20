using System;

namespace Lab4
{
	public class Rectangle:Shape
	{
        private double _Height;
        private double _Width;
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public double Width
        {
            get { return _Width; }
            set { _Width = Math.Max(value , 1); }
        }
        public override string Color
        {
            get
            {
                return _Color;
            }
        }
        public Rectangle ()
		{
            Height = 1.0;
            Width = 1.0;
            _Color = "Gold";
		}
        public Rectangle (string c,double w,double h)
        {
            Height = h;
            Width = w;
            _Color = c;
        }
        public Rectangle (Rectangle r)
        {
            Height = r.Height;
            Width = r.Width;
            _Color = r.Color;
        }
        public override double getArea()
        {
            return Height * Width;
        }
        public override double getPerimeter()
        {
            return (Height * 2) + (Width * 2);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

