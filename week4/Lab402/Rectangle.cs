using System;

namespace Lab4
{
	public class Rectangle:Shape
	{

        private double _Height, _Width;      

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

        public Rectangle()
		{
            _Height = 1.0;
            _Width = 1;
            Color = "gold";
		}
        public Rectangle(string c,double w,double h)
        {
            _Height = h;
            _Width = w;
            Color = c;
        }
        public Rectangle(Rectangle r)
        {
            _Height = r._Height;
            _Width = r._Width;
            Color = r.Color;      
        }
        public override double getArea()
        {
            return Height * Width;
        }
    
        public override double getPerimeter()
        {
            return (Width * 2) + (Height * 2);
        }

        //[Rectangle: width=4, height=5, area=20, color="red"]
        public override string ToString()
        {
            string output = ("[Rectangle: Width= " + Width + ", height= " + Height + ", area=" + getArea() + ",color=''" + Color+"''");
            return output;
        }
        public static double printPerimeter(Rectangle a)
        {
            return a.getPerimeter();
        }
    }
}

