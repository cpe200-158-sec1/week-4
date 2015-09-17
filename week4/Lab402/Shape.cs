using System;

namespace Lab4
{
	public abstract class Shape
	{
		protected string _color;
		public abstract string color { get;}
		public abstract double getArea();
		public abstract double getPerimeter();

		public override string ToString ()
		{
			return string.Format ("[Shape: color={0}]", color);
		}
	}
}

