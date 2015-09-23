 using System;

namespace Lab4
{
	public abstract class Shape
	{
        private string _Color;
        public abstract double getArea();
        public abstract double getPerimeter();

        public string Color
        {
            get { return _Color; }
        }

		public Shape ( string color = "gold")
		{
            _Color = color;
		}

        public override string ToString()
        {
            return string.Format("0", Color);
        }
    }
}

