using System;

namespace Lab4
{
    public abstract class Shape
    {
        
        //## Propeties:
        private string _Color; //read - only, color of the shape, default= "gold"
        public string Color
        {
            get;
            set; 
        }

        //## Constructors:
        public Shape()
        {
            Color = "gold";
        }
        public Shape(string c)
        {
            Color = c;
        }

        //## Methods
        public override string ToString()
        {
            return string.Format("{0}", Color);
        }
        public abstract double getArea(); //abstract method, calculate area of the shape
        public abstract double getPerimeter();//abstract method, calculate perimeter of the shape
    
    }
}


