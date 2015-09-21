using System;
/*# 3. Triangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Triangle(): default
- Triangle(string,double,double): takes color,width,height as parameters
- Triangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a triangle
- override ToString() method*/

namespace Lab402
{
	public class Triangle : Shape
	{
		private double _width;
		private double _height;

		public double Width{
			get { return _width;}
			set {
				if(value <= 0)
					_width = 1.0;
				else _width = value ;
			}
		}

		public double Height{
			get { return _height;}
			set {
				if(value <= 0)
					_height = 1.0;
				else _height = value ;
			}
		}


		public Triangle()
		{
			_color = "gold";
			_height = 1.0;
			_width = 1.0;
		}

		public Triangle (string color, double h, double w) : base (color)
		{
			
			_height = h;
			_width = w;

		}

		public Triangle(Triangle T) : base (T.Color)
		{
			
			_height = T.Height;
			_width = T.Width;

		}

		public override double getArea()
		{
			return (Height * Width)/2.0;

		}

		public override double getPerimeter()
		{
			return Width+Height+Math.Sqrt(Width*Width + Height*Height);
		}

		public override string ToString ()
		{
			return string.Format ("Triangle: base={0}, height={1}, area={2}, color={3}", Width, Height,getArea(),Color);
		}


	}
}

