using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        private double _Width;
        private double _Height;
       
        public Rectangle()
        {
            _Width = 1.0;
            _Height = 1.0;
        }
        public Rectangle(string color, double w, double h) : base(color)
        {
            _Width = w;
            _Height = h;
        }
        public Rectangle(Rectangle a) : base(a.Color)
        {
            _Width = a.Width;
            _Height = a.Height;
        }
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value > 0)
                    _Width = value;
                else _Width = 1.0;
            }
        }
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value > 0)
                    _Height = value;
                else _Height = 1.0;
            }
        }
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return 2.0 * (Width + Height);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"" + base.ToString() + "\"]", Width, Height, getArea());
        }
    }
}

