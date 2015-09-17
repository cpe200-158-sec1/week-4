using System;

namespace Lab4
{
	public abstract class Shape
	{
        protected string _Color;
        public abstract string Color
        {
            get;
        }
        public Shape(string Color="gold")
		{
            _Color = Color;
		}
        public abstract override string ToString();
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}

