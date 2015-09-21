using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _Weight;
        public double Width
        {
            get { return _Weight; }
            set
            {
                if(value <= 0)
                {
                    _Weight = 1.0;
                }
                else
                {
                    _Weight = value;
                }
            }
        }
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0)
                {
                    _Height = 1.0;
                }
                else
                {
                    _Height = value;
                }
            }
        }
        public override string Color
        { get; }

        public Triangle ()
		{
            Color = "gold";
            _Weight = 1.0;
            _Height = 1.0;
		}
        public Triangle(string c, double w, double h) {
            Color = c;
            _Weight = w;
            _Height = h;
        }
        public Triangle(Rectangle r)
        {
            Color = r.Color;
            _Weight = r.Width;
            _Height = r.Height;
        }
        public override double getPerimeter()
        {
            return _Weight+(Math.Sqrt((Math.Pow(_Weight,2))+(Math.Pow(_Height,2))))+_Height;
        }
        public override double getArea()
        {
            return 0.5 * _Weight * _Height;
        }

        //Tostring
        public override string ToString()
        {
            string s = "[Triangle: base = "+_Weight+", height = "+_Height+", area = "+getArea()+", color = "+Color+"]";
            return s;
        }
       

    }
}

