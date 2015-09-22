using System;

namespace Lab4
{
	public abstract class Shape
	{
        private string _color;
        public string Color
        {
            get;
            set;
        }

		public Shape (string pColor = "gold")
		{
            Color = pColor;
		}

        public override string ToString()
        {
            return string.Format("[color={0}]", Color);
        }
        public abstract double getArea();
        public abstract double getPerimeter();
    }
}

