using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width, _height;
        private  string _color;
        public override string color
        {
            get { return _color; }
        }

        public double width
        {
            get { return _width; }
            set {
                if (value<0)
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


        public  Rectangle ()
		{
            _color = "gold";
            _height = 1.0;
            _width = 1.0;

        }
        public Rectangle(string colorname) : base(colorname)
        {

            _color = colorname;
            _height = 1;
            _width = 1;
        }


        public Rectangle(string colorname, double w, double h) : base(colorname)
        {
            _color = colorname;
            _height = h;
            _width = w;
        }

        public Rectangle(Rectangle r)
        {
            _color = r.color;
            _height = r.height;
            _width = r.width;
        }

         public override double getArea()
        {

            return _height * _width;
        }

        public override double getPerimeter()
        {

            return _height *2+ _width*2;
        }

        public override string ToString()
        {
            //[Rectangle: width=4, height=5, area=20, color="red"]
            string output = "[Rectangle: width="+_width+", height="+_height+" area="+getArea()+", color="+ _color + "]";
            return output;
        }

    }
}

