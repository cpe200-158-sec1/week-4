using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        //            - Cylinder() : default
        //- Cylinder(double, double) : takes radius, height as a paramenters
        //- Cylinder(double, double, double, double) : takes x, y, raduis, height as parameters
        //- Cylinder(Circle) : takes a circle as parameter and use its properties for the Cylinder
        //- Cylinder(Cylinder) : copy constructor
        private double _Height;
        private Circle a;
        public Cylinder()
        {
            a = new Circle();
            _Height = 1.0;
        }
        public Cylinder(double radius, double height)
        {
            a = new Circle(radius);
            _Height = height;
        }
        public Cylinder(double x, double y, double radius, double height)
        {
            a = new Circle(x, y, radius);
            _Height = height;
        }
        public Cylinder(Circle copy)
        {
            a = new Circle(copy);
            _Height = 1.0;
        }
        public Cylinder(Cylinder copycon)
        {
            a = new Circle(copycon.a);
            _Height = copycon._Height;
        }
        private double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        //        ## Methods:
        //- getArea(): calculate outter surface area of the cylinder(should NOT have redundant code with the superclass)
        //- getVolume(): calculate volume of the cylinder(should NOT have redundant code with the superclass)
        //- override ToString() method

        public override double getArea()
        {
            return a.getArea() * 2 + ((Math.PI *1.00)* 2 * a.Radius * _Height);
        }
        public double getVolume()
        {
            return a.getArea()*_Height;
        }
        public override string ToString()
        {
           // [Cylinder: center(1, 1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
            return string.Format("[Cylinder: {0}, radius={1}, height={2}, surface={3}, volume={4}",a.XY,a.Radius,_Height,getArea(),getVolume());
        }


    }
}

