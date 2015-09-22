using System;

namespace Lab4
{
    public abstract class Shape
    {
        private string _Color;
        //read only color of the shape, default="gold"
        public abstract double getArea();
        public abstract double getPerimeter();

        public string color
        {
            get { return _Color; }

        }


        public Shape(string co = "gold")
        {
            _Color = co;
        }

        public override string ToString()
        {
            return string.Format("0", color);
        }
    }
}

