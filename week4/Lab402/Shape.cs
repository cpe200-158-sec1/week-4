using System;

namespace Lab4
{
	public abstract class Shape
	{      //properties
        private string _Color;
        public string Color
        {
            get { return _Color; }
        }

            //constructor
		public Shape(string c)
		{
            _Color = c;
		}

        //methode
        public void getArea(){
            //abstract method, calculate area of the shape
        }
        public void getPerimeter()
        {
            //abstract method, calculate perimeter of the shape
        }

        //Tostring
        public override string ToString()
        {
            string s;
            return s;
        }
    }
}

