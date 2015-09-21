using System;

namespace Lab4
{
	public abstract class Shape
	{
        protected string color;
        
        public Shape (string c = "gold")
        {
            color = c;
        }
        public string Color
        {
            get
            {
                return color;
            }
        }
        public abstract double getArea();

        public abstract double getPerimeter();

        public override string ToString()
        {
            return string.Format("[color={0}]",Color);
        }
    }
}

