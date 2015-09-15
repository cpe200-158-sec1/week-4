using System;

namespace Lab4
{
    public abstract class Shape
    {
        private double height;
        private double width;
        private string color = "gold";
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = String.Copy(value); }
        }
        /*public Shape(string col)
        {
            color = String.Copy(col);
        }*/
        public Shape()
        {
            color = "gold";
        }
        public virtual double getArea()
        {
            return this.Height * this.Width;
        }
        public double getPerimeter()
        {
            return this.height * 2 + this.width * 2;
        }
    }
}

