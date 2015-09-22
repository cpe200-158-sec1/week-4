using System;

namespace Lab402
{
	public class Rectangle : Shape
	{
        private double _Width;
        private double _Height;

        public Rectangle()
        {
            Width = 1.0;
            Height = 1.0;
            _Color = "gold";
        }

        public Rectangle (string c, double w, double h)
        {
            Width = w;
            Height = h;
            _Color = c;
        }

        public Rectangle (Rectangle r)
        {
            Width = r.Width;
            Height = r.Height;
            _Color = r._Color;
        }

        public double Width
        {
            get { return _Width; }
            set {  if (value >0) { _Width = value; }
                   else { _Width = 1.0; }
            }
        }

        public double Height
        {
            get { return _Height; }
            set
            {
                if (value > 0) { _Height = value; }
                else { _Width = 1.0; }
            }
        }

        public override string Color
        {
            get
            {
                return Color;
            }
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}{4}{5}]", Width, Height, getArea() , '"' , _Color , '"');
        }

    }
}

