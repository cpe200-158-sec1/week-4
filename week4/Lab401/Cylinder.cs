using System;

namespace Lab4
{
    //Inherit from the Circle class. Use a circle as a base of cylinder
    public class Cylinder:Circle
    {
        //## Properties:
        //- Height: height of the cylinder(>=0, default=1.0)
        private double _h;
        public double Height
        {
            get { return _h; }
            set
            {
                if (value < 0)
                    value = 1.0;
                _h = value;
            }
        }
        //## Constructors:
        //- Cylinder() : default 0,0,1,1
        public Cylinder(double x=0,double y=0,double r=1,double h=1)
        {
            P = new Point(x,y);
            Radius = r;
            Height = h;
        }
        //- Cylinder(Circle) : takes a circle as parameter and use its properties for the Cylinder,h=1.0
        public Cylinder(Circle cir)
        {
            P = new Point(cir.P);
            Radius = cir.Radius;
            Height = 1.0;
        }
        //- Cylinder(Cylinder) : copy constructor
        public Cylinder(Cylinder cy)
        {
            P = new Point(cy.P);
            Radius = cy.Radius;
            Height = cy.Height;
        }

        //## Methods:
        //- getArea(): calculate outter surface area of the cylinder(should NOT have redundant code with the superclass)
        private double getArea()
        {
            return 2 * pi * Radius * ( Height + Radius);
        }
        //- getVolume(): calculate volume of the cylinder(should NOT have redundant code with the superclass)
        private double getVolume()
        {
            return pi * Radius * Radius * Height;
        }
        //- override ToString() method
        public override string ToString()
        {
            //[Cylinder: center(0,0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]
            return "[Cylinder: "+P+", radius="+Radius+", height="+Height+", surface="+getArea()+", volume="+getVolume()+"]";
        }
    }
}

