using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width;
        private double _height;
        public double width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = (value > 0) ? value : 1.0;
            }
        }
        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = (value > 0) ? value : 1.0;
            }
        }

		public Triangle ()
		{
            width = 1.0;
            height = 1.0;
		}

        public Triangle (string c,double ww,double hh)
        {
            color = c;
            width = ww;
            height = hh;
        }

        public Triangle (Triangle re)
        {
            color = re.Color;
            width = re.width;
            height = re.height;
        }

        public override double getArea()
        {
            return width * height * 0.5;
        }

        public override double getPerimeter()
        {
            return width + height + Math.Sqrt((width * width) + (height * height));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", width, height, getArea(), color);
        }
    }
}

