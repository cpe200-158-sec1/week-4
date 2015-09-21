using System;

namespace Lab4
{
	public abstract class Shape
	{
        public string _Color="gold";
        public string Color
        {
            get;
       
        }
        
        public Shape(string a)
        {
            Color = a;
        }

        public abstract double getArea();
        public abstract double Perimeter();
        
        

        

        

        
		public Shape ()
		{

		}
	}
}

