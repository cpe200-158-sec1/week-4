using System;

namespace Lab402
{
    public abstract class Shape
    {
       

            //## Propeties:

            //- string Color: read-only, color of the shape, default="gold"

        protected string _color;
        public abstract string Color { get; }

        //## Constructors:
        //- no default constructor
        //- Shape(string) : takes color as a parameter

        public Shape(string color = "gold")
        {
            _color = Color;
        }
        //## Methods
        //- overriding ToString()
        //- getArea(): abstract method, calculate area of the shape
        //- getPerimeter(): abstract method, calculate perimeter of the shape
        public abstract double getArea();

        public abstract double getPerimeter();

    
    }
}


