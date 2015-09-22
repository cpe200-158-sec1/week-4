using System;

namespace Lab402
{
	public class Triangle : Shape
	{
        private double _Width;
        private double _Height;

		public Triangle ()
		{
            Width = 1.0;
            Height = 1.0;
            _Color = "gold";
		}

        public Triangle(string c, double w, double h)
        {
            Width = w;
            Height = h;
            _Color = c;
        }

        public Triangle(Triangle t)
        {
            Width = t.Width;
            Height = t.Height;
            _Color = t._Color;
        }

        public double Width
        {
            get { return _Width; }
            set { if ( value > 0 ) { _Width = value; }
                  else { _Width = 1.0; }
            }
        }

        public double Height
        {
            get { return _Height; }
            set { if ( value > 0 ) { _Height = value; }
                  else { _Height = 1.0; }
            }
        }

        public override double getArea()
        {
            return ( Width * Height) /2 ;
        }

        public override double getPerimeter()
        {
            return Math.Sqrt(Width*Width + Height*Height) + Width + Height;
        }

        public override string Color
        {
            get
            {
                return _Color;
            }
        }

        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color={3}{4}{5}]" , Width , Height , getArea() , '"', _Color , '"');
        }

    }
}

