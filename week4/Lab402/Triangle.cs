using System;

namespace Lab402
{
    public class Triangle : Shape
    {
        //## Properties:
        //- double Width,Height: dimension of rectangle (>0, default=1.0)
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
        //- Triangle() : default
        //- Triangle(string, double, double) : takes color, width, height as parameters
        public Triangle(string color = "gold", double w = 1.0, double h = 1.0)
        {
            //Defalt : [Rectangle: width=1, height=1, area=1, color="gold"]
            _color = color;
            Width = w;
            Height = h;
        }
        //- Triangle(Rectangle) : copy constructor
        public Triangle(Triangle t)
        {
            _color = t._color;
            Width = t.Width;
            Height = t.Height;
        }

        //## Methodes : 
        public override string Color
        {
            get
            {
                return _color;
            }
        }
        public override double getArea()
        {
            return Height * Width / 2;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height)); ;
        }
        public override string ToString()
        {
            return  "[Triangle : width=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=" + Color + "]";
        }
        
    }
}

