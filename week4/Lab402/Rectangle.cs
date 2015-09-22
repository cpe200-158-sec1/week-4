using System;

namespace Lab402
{
	public class Rectangle : Shape
	{
        private double _Width;
        private double _Height;

        public double Width
        {
            get { return _Width; }
            set
            {
                _Width = (value > 0) ? value : 1.0;
            }
        }

        public double Height
        {
            get { return _Height; }
            set
            {
                _Height = (value > 0) ? value : 1.0;
            }
        }

        public override string Color
        {
            get { return _Color; }
        }

		public Rectangle ()
		{
            Width = 1.0;
            Height = 1.0;
            _Color = "gold";
		}

        public Rectangle (string c , double w, double h)
        {
            _Color = c;
            Width = w;
            Height = h;
        }

        public Rectangle ( Rectangle r)
        {
            _Color = r._Color;
            Width = r._Width;
            Height = r._Height;
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2*Width + 2*Height;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color={3}{4}{5}]" , Width , Height , getArea() , '"' , Color , '"');
        }
    }
}

