using System;

namespace Lab4
{
    public class Triangle : Shape
    {
        // # 3. Triangle Class:

        //## Properties:
        //- double Width, Height: dimension of rectangle(>0, default=1.0)
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value > 0) Width = value;
                else Width = 1.0;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value > 0) Height = value;
                else Height = 1.0;
            }
        }

        //## Constructors:
        //- Triangle() : default
        public Triangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        
        //- Triangle(string, double, double) : takes color, width, height as parameters
        public Triangle (string inColor, double inWidth, double inHeight)
        {
            Color = inColor;
            Height = inHeight;
            Width = inWidth;
        }
        //- Triangle(Rectangle) : copy constructor
        public Triangle (Triangle inTri)
        {
            Color = inTri.Color;
            Width = inTri.Width;
            Height = inTri.Height;
        }

        //## Methods:
        //- getArea(): get area of a triangle
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }

        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }

        //- override ToString() method
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

