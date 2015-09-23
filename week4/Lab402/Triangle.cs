using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _Width;
        private double _Height;
        
        public Triangle ()
		{
            _Height = 1.0;
            _Width = 1.0;
		}
        public Triangle(string color, double w, double h) : base(color)
        {
            _Width = w;
            _Height = h;
        }
        public Triangle(Rectangle a) : base(a.Color)
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
            return Width * Height *0.5;
        }
        public override double getPerimeter()
        {
            return Width + Height +(Math.Sqrt(Math.Pow(Width,2)+Math.Pow(Height,2)));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
            
        }
    }
}

