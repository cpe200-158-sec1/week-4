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
        public Triangle()
        {
            Width = 1.0;
            Height = 1.0;
            _color = "Gold";
        }
        public Triangle(string c, double w, double h)
        {
            Width = w;
            Height = h;
            _color = c;
        }
        public Triangle(Rectangle r)
        {
            Width = r.Width;
            Height = r.Height;
            _color = r.Color;
        }
        public override double getArea()
        {
            return this.Width * this.Height / 2;
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

