using System;

namespace Lab4
{
	public abstract class Shape
	{
        protected string _Color;
        public Shape(string color = "gold")
        {
            _Color = color;
        }
        public string Color
        {
            get { return _Color; }
        }
        public override string ToString()
        {
            return string.Format("{0}",Color);
        }
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}

