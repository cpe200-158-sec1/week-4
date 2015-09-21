using System;

namespace Lab4
{
    public class Triangle : Shape
    {
        // # 3. Triangle Class:

        //## Properties:
        //- double Width, Height: dimension of rectangle(>0, default=1.0)
        

        //## Constructors:
        //- Triangle() : default
        public Triangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        
        //- Triangle(string, double, double) : takes color, width, height as parameters
        public Triangle (string inColor, double inWidth, double inHeight) : base(inColor)
        {
            Height = inHeight;
            Width = inWidth;
        }
        //- Triangle(Rectangle) : copy constructor
        public Triangle (Triangle inTri) : base(inTri.Color)
        {
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
            return string.Format("[Triangle : width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

