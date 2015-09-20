using System;

namespace Lab4
{
	public abstract class Shape
	{
        protected string _Color;
        public abstract string Color { get; }
        public abstract double getArea();
        public abstract double getPerimeter();
	}
}

