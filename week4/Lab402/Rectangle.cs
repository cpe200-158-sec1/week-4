using System;
/*# 2. Rectangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Rectangle(): default
- Rectangle(string,double,double): takes color,width,height as parameters
- Rectangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a rectangle
- override ToString() method*/

namespace Lab402
{
	public class Rectangle : Shape
	{
		private double _width;
		private double _height;

		public double Width
		{
			get { return _width;}
			set {
				if( value <= 0)
					_width = 1.0;
				else
					_width = value;
			}
		}

		public double Height
		{
			get { return _height;}
			set {
				if( value <= 0)
					_height = 1.0;
				else
					_height = value;
			}
		}

		public Rectangle()
		{
			_color = "gold";
			_height = 1.0;
			_width = 1.0;
		}

		public Rectangle (string color,double w,double h) : base (color)
		{
			
			_height = h;
			_width = w;
		}

		public Rectangle(Rectangle R) : base (R.Color) 
		{
			
			_height = R.Height;
			_width = R.Width;
		}

		public override double getArea()
		{
			return Height * Width;
		}

		public override double getPerimeter()
		{
			return 2.0 * (Width+Height);
		}


		public override string ToString ()
		{
			return string.Format ("[Rectangle: Width={0}, Height={1} ,Area={2} ,Color = {3}]", Width, Height,getArea(),Color);
		}

	}
}

