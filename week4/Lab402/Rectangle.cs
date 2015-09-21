using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width;
        private double _height;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public override string Color
        {
            get
            {
                return _color;
            }
        }
        public Rectangle ()
		{
            Height = 1.0;
            Width = 1.0;
            _color = "Gold";
		}
        public Rectangle (string c,double w,double h)
        {
            Height = h;
            Width = w;
            _color = c;
        }
        public Rectangle (Rectangle r)
        {
            Height = r.Height;
            Width = r.Width;
            _color = r.Color;
        }
        public override double getArea()
        {
            return this.Width * this.Height;
        }
        public override double getPerimeter()
        {
            return (this.Height * 2) + (this.Width * 2);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

