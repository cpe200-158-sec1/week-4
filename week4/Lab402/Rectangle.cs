using System;

namespace Lab402
{
	public class Rectangle : Shape
    {
        //## Properties:
        //- double Width, Height: dimension of rectangle(>0, default=1.0)
        public override string Color
        {
            get
            {
                return _color ;
            }
        }
        private double _width;
        private double _height;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    value = 1.0;
                _width = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    value = 1.0;
                _height = value;
            }
        }
        //## Constructors:
        //- Rectangle() : default
        //- Rectangle(string, double, double) : takes color, width, height as parameters
        public Rectangle(string color="gold",double w = 1.0,double h = 1.0)
        {
            //Defalt : [Rectangle: width=1, height=1, area=1, color="gold"]
            _color = color;
            Width = w;
            Height = h;
        }
        //- Rectangle(Rectangle) : copy constructor
        public Rectangle(Rectangle r)
        {
            _color = r._color;
            Width = r.Width;
            Height = r.Height;
        }
        //## Methods:
        //- getArea(): get area of a rectangle
        //- override ToString() method
        public override double getArea()
        {
            return Height * Width;
        }
        public override double getPerimeter()
        {
            return 2 * (Height + Width);
        }
        public override string ToString()
        {
            //[Rectangle: width=4, height=5, area=20, color="red"]
            return "[Rectangle : width="+Width+", height="+Height+", area="+getArea()+", color="+Color+"]";
        }
       
    }
}

