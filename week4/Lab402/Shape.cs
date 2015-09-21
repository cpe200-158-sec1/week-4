using System;

namespace Lab4
{   //# 1. Shape Class:
    // Abstract class
    public abstract class Shape
    {   
        //## Propeties:
        //- string Color: read-only, color of the shape, default="gold"
        private string _color ;

        public string Color
        {
            get;
            set;
        }

        //## Constructors:
        //- no default constructor
        public Shape()
        {
            Color = "gold";
        }
        //- Shape(string) : takes color as a parameter
        public Shape(string incolor)
        {
            Color = incolor;
        }
        //## Methods
        //- overriding ToString()
        public override string ToString()
        {
            return string.Format("[color={0}]", Color);
        }
        //- getArea(): abstract method, calculate area of the shape
        public abstract double getArea();
        //- getPerimeter(): abstract method, calculate perimeter of the shape
        public abstract double getPerimeter();

    }
}

