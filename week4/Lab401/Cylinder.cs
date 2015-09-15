using System;

namespace Lab4
{
	public class Cylinder
	{
        public double height;
        public Circle rr=new Circle();
        

        public double Height
        {
            get { return height; }
            set
            {
                if (height >= 0)
                {
                    height = value;
                }
            }
        }


        public Cylinder ()
		{
           height = 1.0;
		}

        public Cylinder(double r,double h)
        {
            rr.redius = r;
            height = h;
        }
       
        public Cylinder(double x,double y,double r,double h)
        {
            rr._pointcenter.x = x;
            rr._pointcenter.y = y;
            rr.redius = r;
            height = h;
            
        }

        public Cylinder(Circle a)
        {
            Console.WriteLine(a._pointcenter.x);
            rr._pointcenter.x = a._pointcenter.x;
            rr._pointcenter.y = a._pointcenter.y;
            rr.redius = a.redius;
            height = 1.0;
            
        }

        public Cylinder(Cylinder a)
        {
            rr._pointcenter.x = a.rr._pointcenter.x;
            rr._pointcenter.y = a.rr._pointcenter.y;
            rr.redius = a.rr.redius;
            height = a.height;
        }

        public double getArea()
        {
            double area;
            area = ((Math.PI * (2 * rr.redius)) * height) + (2*(Math.PI*rr.redius*rr.redius));
            return area;
        }

        public double getVolume()
        {
            double volume;
            volume = Math.PI * rr.redius * rr.redius * height;
            return volume;
        }

        public override string ToString()
        {
            string output;
            output = ("[Cylinder: center(" + rr._pointcenter.x + "," + rr._pointcenter.y + "), radius=" + rr.redius +" height="+height+ ", surface=" + getArea()+", volume="+getVolume()+"]");
            return output;
        }
    }
}
/*
## Properties:
- Height: height of the cylinder(>=0, default=1.0)

## Constructors:
- Cylinder(): default
- Cylinder(double, double): takes radius, height as a paramenters
- Cylinder(double, double, double, double): takes x, y, raduis, height as parameters
- Cylinder(Circle): takes a circle as parameter and use its properties for the Cylinder
- Cylinder(Cylinder): copy constructor

## Methods:
- getArea(): calculate outter surface area of the cylinder(should NOT have redundant code with the superclass)
- getVolume(): calculate volume of the cylinder(should NOT have redundant code with the superclass)
- override ToString() method
[Circle: center(0,0), radius=1, area=3.14159265358979]
[Circle: center(1.5,5), radius=2, area=12.5663706143592]
[Circle: center(1.5,5), radius=2, area=12.5663706143592]
[Cylinder: center(0,0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]
[Cylinder: center(1.5,5), radius=2, height=1, surface=37.6991118430775, volume=12.5663706143592]
[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
*/
