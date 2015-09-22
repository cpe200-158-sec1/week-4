using System;

namespace Lab402
{
	public class Triangle : Shape
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

		public Triangle ()
		{
            Width = 1.0;
            Height = 1.0;
            _Color = "gold";
		}

        public Triangle (string c , double w , double h)
        {
            _Color = c;
            Width = w;
            Height = h;
        }

        public Triangle (Triangle t)
        {
            _Color = t._Color;
            Width = t._Width;
            Height = t._Height;
        }

        public override string Color
        {
            get
            {
                return _Color;
            }
        }

        public override double getArea()
        {
            return ( Width * Height ) / 2;
        }

        public override double getPerimeter()
        {
           
            return Math.Sqrt((Width * Width) +( Height * Height ))+ Width + Height;
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}{4}{5}]", Width, Height, getArea() , '"' , Color , '"');
        }
    }
}

