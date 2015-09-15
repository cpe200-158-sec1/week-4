using System;

namespace Lab4
{
   
	public abstract class Shape
	{
        public abstract double getArea();
        public abstract double getPerimeter();

        public string _Color="gold";

        public string Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
            }
        }
        public Shape()
        {
            _Color = "gold";
        }
		public Shape (string c)
		{
            _Color = c;
		}   

	}
}

