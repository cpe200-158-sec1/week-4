using System;

namespace Lab4
{
	public abstract class Shape
	{
		public Shape ()
		{
            //## Propeties:
            private string _Color; //read - only, color of the shape, default= "gold"
            public string Color
            {
                get { return _Color; }
            }
            //## Constructors:
            Shape()
            {
                _Color = "gold";
            }
            Shape(string color)
            {
                _Color = color;
        }
            //## Methods
            public overriding ToString()
            {
                return string.Format();
            }
            public getArea() { return } //abstract method, calculate area of the shape
            public getPerimeter() { return 2*(_ }//abstract method, calculate perimeter of the shape














    }
    }
}

