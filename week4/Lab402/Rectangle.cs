using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
       
        //concrete member
        private double _Width;
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value < 0)
                {
                    _Width = 1.0;
                }
                else
                {
                    _Width = value;
                }
            }
        }
        private double _Height;
        public double Height {
            get { return _Height; }
            set
            {
                if (value < 0)
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


        //constructor
        public Rectangle ()
		{
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
		}
        public Rectangle(string s, double w, double h)
        {
            Color = s;      
            _Width = w;
            _Height = h;
        }
        public Rectangle(Rectangle r)
        {
            Color = r.Color;
            _Height = r._Height;
            _Width = r._Width;           
        }

        //methode
        public override double getArea()
        {
            return _Height * _Width;
        }
        //abstract method, calculate area of the shape        
        public override double getPerimeter()
        {
            return (2 * _Width) + (2 * _Height);
        }

        //Tostring
        public override string ToString()
        {
            string s = "[Rectangle: width =" +_Width+", height ="+_Height+", area ="+getArea()+", color ="+Color+"]";

            return s;
        }

    }
}

