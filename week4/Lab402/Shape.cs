using System;

namespace Lab4
{
	public abstract class Shape
	{
        abstract public string color { get; }
        private string _color;

        public Shape()
        { }

        public Shape(string colorname)
        {
            _color = colorname;
        }

        public abstract double getArea();


        public abstract double getPerimeter();


        public override string ToString()
        {
           // [Triangle: base=4, height=5, area=10, color="blue"]
        string output="";
            return output;
        }

    }
}

