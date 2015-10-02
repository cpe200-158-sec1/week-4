using System;

namespace Lab401
{
    public class Cylinder : Circle
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }
        public Cylinder(double x = 0, double y = 0, double r = 1, double h = 1)
        {
            C = new Point(x, y);
            H = h;
            R = r;

        }
        public Cylinder(Circle cir)
        {
            C = new Point(cir.C);
            R = cir.R;
            H = 1.0;
        }
        public Cylinder(Cylinder cy)
        {
            C = new Point(cy.C);
            R = cy.R;
            H = cy.H;
        }
        private double getArea()
        {
            return 2 * pi * R * (H + R);
        }
        private double getVolume()
        {
            return pi * R * R * H;
        }
        public override string ToString()
        {
            
            return "[Cylinder: " + C + ", radius=" + R + ", height=" + H + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
        }
    }
}


