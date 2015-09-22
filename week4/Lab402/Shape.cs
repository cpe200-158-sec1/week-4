using System;

namespace Lab4
{
	public abstract class Shape
	{
        protected String _color;
        public String Color
        {
            get;
            set;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
	}
}

