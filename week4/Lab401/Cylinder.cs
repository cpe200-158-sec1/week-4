using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        //## Properties

        private double _Height;
        private Circle _Surface;
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value >= 0)
                    _Height = value;
                else _Height = 1.0;
            }
        }
        public Circle Surface
        {
            get { return _Surface; }
            set
            { _Surface = value; }
        }

        //## Constructors
        public Cylinder()
        {
            Surface = new Circle();
            Height = 1.0;
        }
        public Cylinder(double r, double h)
        {
            Surface = new Circle(r);
            Height = h;
        }
        public Cylinder(double a, double b, double r, double h)
        {
            Surface = new Circle(a, b, r);
            Height = h;
        }
        public Cylinder(Circle c)
        {
            Surface = new Circle(c.Center.X,c.Center.Y,c.Radius);
            Height = 1.0;
        }
        public Cylinder(Cylinder cyl)
        {
            Surface = new Circle(cyl.Surface.Center.X, cyl.Surface.Center.Y, cyl.Surface.Radius);
            Height = cyl.Height;
        }
        //## Methods
        public double getAreaCylinder()
        {
            return ((2 * Surface.getAreaCircle()) + (Height * 2 * Math.PI * Surface.Radius));
        }
        public double getVolume()
        {
            return Surface.getAreaCircle() * Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", Surface.Center, Surface.Radius, Height, getAreaCylinder(), getVolume());
        }
        ///////////////////////
    }
}



