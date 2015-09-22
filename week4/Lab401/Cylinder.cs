using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double _hight;
        public double Hight
        {
            get { return _hight; }
            set { _hight = value; }
        }
        public Cylinder() : base(0, 0, 1)
        {
            Hight = 1;
        }
        public Cylinder(double a, double b) 
        {
            X = 0;
            Y = 0;
            Radius = a;
            Hight = b;
        }
        public Cylinder(double a, double b, double c, double d) : base(a,b,c)
        {
            Hight = d;
        }
        public Cylinder(Circle a):base(a.X, a.Y, a.Radius)
        {
           
            Hight = 1;
        }
        public Cylinder(Cylinder a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
            Hight = a.Hight;
        }
        public override double getArea()
        {
            return 2 * Math.PI * Radius * Hight + 2 * Math.PI * Radius * Radius;
        }
        public double getVolume()
        {
            return Math.PI * Radius * Radius * Hight;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius = {2},height={5}, surface={3}, volume={4}", this.X, this.Y, this.Radius, this.getArea(),this.getVolume(),this.Hight);
        }
    }
}

