using System;

namespace Lab402
{
	public abstract class Shape
	{
        protected string _color;
        public abstract string Color { get; }
        public abstract double getArea();
        public abstract double getPerimeter();

    }
}

