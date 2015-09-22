using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double _height;
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
            Height = 1.0;
        }
        public Cylinder(double pRadius, double pHeight) : base (pRadius)
        {
            Height = pHeight;
        }
        public Cylinder(double pX, double pY, double pRadius, double pHeight) : base (pX, pY, pRadius)
        {
            Height = pHeight;
        }
        public Cylinder(Circle pCircle) : base (pCircle.Center.X, pCircle.Center.Y, pCircle.Radius)
        {
            Height = 1.0;
        }
        public Cylinder(Cylinder pCylinder) : base (pCylinder.Center.X, pCylinder.Center.Y, pCylinder.Radius)
        {
            Height = pCylinder.Height;
        }

        public override double getArea()
        {
            double pi = Math.PI;
            return ((2.0 * base.getArea()) + (2 * (pi) * Radius * Height));
        }
        public double getVolume()
        {
            return (base.getArea() * Height);
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", Center, Radius, Height, getArea(), getVolume());
        }
    }
}

