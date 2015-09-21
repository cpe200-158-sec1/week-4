using System;

/*# 1. Shape Class:
Abstract class

## Propeties:
- string Color: read-only, color of the shape, default="gold"

## Constructors:
- no default constructor
- Shape(string): takes color as a parameter

## Methods
- overriding ToString()
- getArea(): abstract method, calculate area of the shape
- getPerimeter(): abstract method, calculate perimeter of the shape
*/

namespace Lab402
{
	public abstract class Shape
	{
		protected string _color;

		public string Color {
			get{return _color;} 	
		}

		public Shape(string color = "gold")
		{
			_color = color;
		}

		public override string ToString ()
		{
			return string.Format ("{0}", Color);
		}

		public abstract double getArea();
		public abstract double getPerimeter();


			
		
	}
}

