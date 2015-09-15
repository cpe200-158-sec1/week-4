using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private Circle _surface;
        private double _height;
        public Circle Surface
        {
            get;
            set;
        }
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
                else
                {
                    _height = 1;
                }
            }
        }

        public Cylinder()
        {
            Surface = new Circle();
            Height = 1.0;
        }
        public Cylinder(double pRadius, double pHeight)
        {
            Surface = new Circle(pRadius);
            Height = pHeight;
        }
        public Cylinder(double pX, double pY, double pRadius, double pHeight)
        {
            Surface = new Circle(pX, pY, pRadius);
            Height = pHeight;
        }
        public Cylinder(Circle pCircle)
        {
            Surface = new Circle(pCircle.Center.X, pCircle.Center.Y, pCircle.Radius);
            Height = 1.0;
        }
        public Cylinder(Cylinder pCylinder)
        {
            Surface = new Circle(pCylinder.Surface.Center.X, pCylinder.Surface.Center.Y, pCylinder.Surface.Radius);
            Height = pCylinder.Height;
        }

        public override double getArea()
        {
            double pi = Math.PI;
            return ((2.0 * Surface.getArea()) + (2 * (pi) * Surface.Radius * Height));
        }
        public double getVolume()
        {
            return (Surface.getArea() * Height);
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", Surface.Center, Surface.Radius, Height, getArea(), getVolume());
        }
    }
}

