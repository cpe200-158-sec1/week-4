using System;

/*# 3. Cylinder Class:
Inherit from the Circle class. Use a circle as a base of cylinder

## Properties:
- Height: height of the cylinder (>=0, default=1.0)

## Constructors:
- Cylinder(): default
- Cylinder(double,double): takes radius,height as a paramenters
- Cylinder(double,double,double,double): takes x,y,raduis,height as parameters
- Cylinder(Circle): takes a circle as parameter and use its properties for the Cylinder
- Cylinder(Cylinder): copy constructor

	## Methods:
	- getArea(): calculate outter surface area of the cylinder (should NOT have redundant code with the superclass)
	- getVolume(): calculate volume of the cylinder (should NOT have redundant code with the superclass)
	- override ToString() method*/

namespace Lab4
{
    public class Cylinder : Circle

    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set
            {

                if (value >= 0)
                    _height = value;
                else
                    _height = 1.0;
            }

        }



        public Cylinder()
        {

            Center = new Point();
            _height = 1.0;
        }

        public Cylinder(double r, double h)
        {
            Radius = r;
            _height = h;
        }

        public Cylinder(double x, double y, double r, double h)
        {
            Radius = r;
            _height = h;
            Center = new Point(x, y);
        }

        public Cylinder(Circle C)
        {
            _height = 1.0;
            Center = C.Center;
            Radius = C.Radius;
        }

        public Cylinder(Cylinder Cy)
        {
            _height = Cy._height;
            Center = Cy.Center;
            Radius = Cy.Radius;
        }

        public double getArea()
        {
            return (Math.PI * Radius * Radius * 2) + (2 * Math.PI * Radius * Height);
        }

        public double getVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center {0}, radius={1}, height={2}, surface={3}, volume={4}]", Center, Radius, Height, getArea(), getVolume());
        }

    }
}

