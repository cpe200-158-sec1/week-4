using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        //# 2. Rectangle Class:

        //## Properties:
        //- double Width, Height: dimension of rectangle(>0, default=1.0)

        

        //## Constructors:
        //- Rectangle(): default
        public Rectangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        //- Rectangle(string, double, double): takes color, width, height as parameters
        public Rectangle(string inColor, double inWidth, double inHeight) : base(inColor)
        {
            Width = inWidth;
            Height = inHeight;
        }
        //- Rectangle(Rectangle): copy constructor
        public Rectangle(Rectangle inRec) : base(inRec.Color)
        {
            Width = inRec.Width;
            Height = inRec.Height;
        }

        //## Methods:
        //- getArea(): get area of a rectangle
        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2.0 * (Width + Height);
        }
        //- override ToString() method
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }


    }
}


