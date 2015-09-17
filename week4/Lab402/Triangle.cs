using System;

namespace Lab4
{
	public class Triangle:Shape
    {
        public override string Color
        {
            get { return _Color; }
        }
        private double _Width, _Height;
        public double Width
        {
            get { return _Width; }
            set { _Width = (value > 0) ? value : 1.0; }
        }
        public double Height
        {
            get { return _Height; }
            set { _Height = (value > 0) ? value : 1.0; }
        }

        public Triangle()
        {
            Width = 1.0;
            Height = 1.0;
            _Color = "gold";
        }
        public Triangle(string Color = "gold", double a = 1.0, double b = 1.0)
        {
            Width = a;
            Height = b;
            _Color = Color;
        }
        public Triangle(Triangle a)
        {
            Width = a.Width;
            Height = a.Height;
            _Color = a._Color;
        }
        public override double getArea()
        {
            return Height * Width / 2;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
        public override string ToString()
        {
            return string.Format("[Triangle : base={0}, height={1}, area={2}, color=" + Color + "]", this.Width, this.Height, this.getArea());
        }
    }
}

