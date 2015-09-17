using System;

namespace Lab4
{
	public class Rectangle
	{
		public Rectangle ()
		{
            //## Properties:
            private double _Width, _Height; //dimension of rectangle (>0, default=1.0)
            public string Color;
            public double Width
            {
                get { return _Width;}
                set { if (value < 0)
                    _ Width = 1.0;
                else _Width = value; }
            }

            public double Height
            {
                get { return _Heigth; }
                set
                {
                    if (value < 0)
                        _ Height = 1.0;
                    else _ Height = value;
                }
            }

            //## Constructors:

            //Rectangle() : default
            public Rectangle()
            {
                Color = "gold";
                _Width = 1.0;
                _Height = 1.0;

            }
            public Rectangle(string color, double width, double height)
            {
                Color = color;
                _Width = width;
                _Height = height;
            } //takes color, width, height as parameters
            public Rectangle(Rectangle r)
            {
                Color = r.Color;
                _Width = r.Width;
                _Height = r.Height;
            } //copy constructor

            //## Methods:
            public double getArea(double width, double height) { return width*height; }//get area of a rectangle
            public override string ToString()
            {
                return string.Format("[Rectangle: width={0}, height={1}, area={2}, color= {3}]",_Width,_Height, getArea(_Width,_Height),Color);
            } //method

//////////
    }
        
    }
}

