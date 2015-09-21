using System;

namespace Lab4
{
	public abstract class Shape
	{
        private string _color ;

        public string Color
        {
            get
            {
                return _color;
            }
        }

        public Shape(string color = "gold")
        {
            _color = color;
        }

        public override string ToString()
        {
            return string.Format("{0}", Color);
        }

        public abstract double getArea();

        public abstract double getPerimeter();

    }
}

