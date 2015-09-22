using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        private double _Width;
        private double _Height;

        public double width
        {
            get { return _Width; }
            set
            {
                if (value > 0)
                {
                    _Width = value;
                }
                else { _Width = 1.0; }
            }//(>0, default=1.0)
        }

        public double height
        {
            get { return _Height; }
            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else { _Height = 1.0; }
            }
        }
        public Rectangle()
        {
            width = 1.0;
            height = 1.0;
        }
        public Rectangle(string c, double w, double h) : base(c)
        {
            width = w;
            height = h;

        }
        public Rectangle(Rectangle cpy) : base(cpy.color)
        {
            width = cpy.width;
            height = cpy.height;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override double getPerimeter()
        {
            return 2.0 * (width + height);
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", width, height, getArea(), color);
        }
    }
}

