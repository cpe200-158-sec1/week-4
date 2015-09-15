using System;

namespace Lab4
{

    public class Cylinder : Circle
	{

        private Circle Surface;
        private double _hight;

        public double Hight
        {
            get
            {
                return _hight;
            }

            set
            {
                if (_hight < 0)
                {
                    //Console.WriteLine("please enter the valid value, set to default");
                    _hight = 1.0;
                }

                else
                {
                    _hight = value;
                }
            }
        }


        public Cylinder ()
		{
            Surface = new Circle();
            Hight = 1.0;
		}

        

        public Cylinder (double iraduis, double ihight)
        {
            Surface = new Circle(iraduis);
            Hight = ihight;
        }

        //- Cylinder(double, double, double, double): takes x, y, raduis, height as parameters

        public Cylinder (double ix, double iy, double iraduis, double ihight)
        {
            Surface = new Circle(ix, iy, iraduis);
            Hight = ihight;
        }

        //- Cylinder(Circle): takes a circle as parameter and use its properties for the Cylinder

        public Cylinder(Circle iCircle)
        {
            Surface = iCircle;

        }

        //- Cylinder(Cylinder): copy constructor

        public Cylinder(Cylinder iCylinder)
        {
            Surface = iCylinder.Surface;
            Hight = iCylinder.Hight;
        }

        //- getArea(): calculate outter surface area of the cylinder(should NOT have redundant code with the superclass)
        
        public override double getArea()
        {
            return Hight * 2 * (Surface.getArea() / Surface.Radius) + 2 * Surface.getArea();
        }
        
        //- getVolume(): calculate volume of the cylinder(should NOT have redundant code with the superclass)

        public double getVolume()
        {
            return Surface.getArea() * Hight;
        }

        //- override ToString() method
        //[Cylinder: center(0, 0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), raduis={2}, hight={3}, surface={4}, volume={5}",Surface.Center.X,Surface.Center.Y, Surface.Radius, Hight, getArea(), getVolume());
        }
    }
}

