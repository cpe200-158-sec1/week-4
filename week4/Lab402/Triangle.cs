using System;

namespace Lab4
{
	public class Triangle : Shape
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
            set { _Width = Math.Max(value, 1); }
        }
        public override string Color
        {
            get
            {
                return _Color;
            }
        }
        public Triangle ()
		{
            Height = 1.0;
            Width = 1.0;
            _Color = "Gold";
		}
        public Triangle (string c,double w,double h)
        {
            Height = h;
            Width = w;
            _Color = c;
        }
        public Triangle (Rectangle t)
        {
            Height = t.Height;
            Width = t.Width;
            _Color = t.Color;
        }
        public override double getArea()
        {
            return Height * Width / 2;
        }
        public override double getPerimeter()
        {
            return Math.Sqrt((this.Height) * (this.Height) + (this.Width) * (this.Width)) + this.Width + this.Height;
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", this.Width, this.Height, this.getArea(), this.Color);
        }
    }
}

