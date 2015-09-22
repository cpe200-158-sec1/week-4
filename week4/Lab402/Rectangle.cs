using System;

namespace Lab402
{
	public class Rectangle : Shape
	{
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if ( value > 0)
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
                if ( value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }

        public Rectangle ()
		{
            _width = 1.0;
            _height = 1.0;
            _color = "gold";
        }

        public Rectangle(string clr1,double w1,double h1)
        {
            _color = clr1;
            _width = w1;
            _height = h1;
        }

        public Rectangle(Rectangle cpy)
        {
            _width = cpy.Width;
            _height = cpy.Height;
            _color = cpy.Color;
        }

        public override string Color
        {
            get
            {
                return _color;
            }
        }

        public override double getArea()
        {
            return (_width*_height);
        }

        public override double getPerimeter()
        {
            return ( _width * 2) + (_height * 2);
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }

    }
}

