using System;

namespace Lab4
{
	public abstract class Shape
	{      //properties
        private string _Color;
        public abstract string Color
        { get; }        
        //methode
        public abstract double getArea();                 
        public abstract double getPerimeter();
    }
}

