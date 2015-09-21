using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width, _height;
        private string _color;
        public override string color
        {
            get { return _color; }
        }
        public double width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                { _width = 1.0; }
                else
                { _width = value; }
            }
        }

        public double height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                { _height = 1.0; }
                else
                { _height = value; }
            }
        }


        public Triangle()
        {
            _color = "gold";
            _height = 1.0;
            _width = 1.0;

        }

        public Triangle(string colorname) : base(colorname) 
        {

            _color = colorname;
            _height = 1;
            _width = 1;
        }

        public Triangle(string colorname, double w, double h) : base(colorname)
        {

            _color = colorname;
            _height = h;
            _width = w;
        }

        public Triangle(Rectangle r)
        {
            _color = r.color;
            _height = r.height;
            _width = r.width;
        }

        public override double getArea()
        {

            return 0.5*_height * _width;
        }

        public override double getPerimeter()
        {

            return _height + _width + Math.Sqrt(_height* _height+ _width* _width);
        }

        public override string ToString()
        {
           
            string output = "[Triangle: base=" + _width + ", height=" + _height + " area=" + getArea() + ", color=" + _color + "]";
            return output;
        }

    }
}

