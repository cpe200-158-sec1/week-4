using System;

namespace Lab4
{   //# 1. Shape Class:
    // Abstract class
    public abstract class Shape
    {   
        //## Propeties:
        //- string Color: read-only, color of the shape, default="gold"
        private string _color ;
        private double _width;
        private double _height;

        public string Color
        {
            get;
            set;
        }



        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }
            }

        }

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1.0;
            }

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

