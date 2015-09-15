using System;
using Lab4;

namespace Lab4 
{
	public class Cylinder : Circle
	{
        private double _height;
        private Circle _surface;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
                else _height = 1;
            }
        }

        public Circle Surface
        {
            get
            {
                return _surface;
            }
            set
            {
                _surface = value;
            }
        }

        public Cylinder()
        {
            Surface = new Circle();
            Height = 1;        
        }

        public Cylinder(double a , double b)
        {   
            Surface = new Circle(a);
            Height = b;
        }

        public Cylinder(double a, double b, double c, double d)
        {
            Surface = new Circle(a,b,c);
            Height = d;
        }

        public Cylinder(Circle a)
        {
            this.Surface = a;
            Height = 1;
        }

        public Cylinder(Cylinder a)
        {
            this.Surface = a.Surface;
            this.Height = a.Height;
        }

        public double getArea()
        {
            return (2 * Surface.getArea()) + (Height * 2 * Math.PI * Surface.Radius);
        }

        public double getVolume()
        {
            return Surface.getArea() * Height;
        }

        public override string ToString()
        {
            return string.Format("Cylinder: {0}, radius={1}, height{2}, surface={3}, volume={4}", Surface.Center, Surface.Radius, Height, getArea(), getVolume());
        }


    }
}

