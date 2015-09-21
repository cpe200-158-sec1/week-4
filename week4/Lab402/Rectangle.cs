using System;

namespace Lab4
{
	public class Rectangle : Shape
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
            
		public Rectangle()
		{
            width = 1.0;
            height = 1.0;
		}

        public Rectangle (string c , double ww , double hh)
        {
            color = c;
            width = ww;
            height = hh;
        }

        public Rectangle (Rectangle re)
        {
            color = re.Color;
            width = re.width;
            height = re.height;
        }

        public override double getArea()
        {
            return width * height;
        }

        public override double getPerimeter()
        {
            return 2 * (width + height);
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", width, height, getArea(), color);
        }
    }
}

