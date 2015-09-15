using System;

namespace Lab4
{
    public class Rectangle : Shape 
    {
        //properties
        private double _Width;
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    _Width = value;
                }
            }
        }
        private double _Height;
        public double Height {
            get { return _Height; }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    _Height = value;
                }
            }
        }

            
        //constructor
        public Rectangle ()
		{
            Width = 1.0;
            Height = 1.0;
		}
        public Rectangle(string s, double w, double h)
        {
            _
            _Width = w;
            _Height = h;
        }
        public Rectangle(Rectangle r)
        {
            //color
            _Height = r._Height;
            _Width = r._Width;           
        }

        //methode
        public void getArea()
        {
            //get area of a rectangle
        }

        //Tostring
        public override string ToString()
        {
            string s;
            return s;
        }

    }
}

