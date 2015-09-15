using System;

namespace Lab4
{
	public class Triangle:Shape
	{      
        private double _Width, _Height;
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0)
                {
                    value = 1.0;
                }
                _Height = value;
            }
        }
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value <= 0)
                {
                    value = 1.0;
                }
                _Width = value;
            }
        }    
        public Triangle ()
		{
            _Height = 1;
            _Width = 1;
            Color = "gold";
        }
        public Triangle(string c,double w,double h)
        {
            _Height = h;       
            _Width = w;
            Color = c;
        }
        public Triangle(Rectangle r)
        {
            _Height = r.Height;
            _Width = r.Width;
            Color = r.Color;
        }
        public override double getArea()
        {
            return (0.5*Width*Height);
        }
        public override double getPerimeter()
        {
            return Width + 2 * (Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        }
        public override string ToString()
        {
            string output = ("[Triangle: base= " + Width + ", height= " + Height + ", area=" + getArea() + ",color=''" + Color+"''");
            return output;
        }

    }
}

