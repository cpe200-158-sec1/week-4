using System;

namespace Lab4
{
    public class Circle : Point
    {
        private Point _center;
        private double _radius;

        public Point Center
        {
            get;
            set;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if (_radius < 0)
                {
                    //Console.WriteLine("please enter the valid value, set to default");
                    _radius = 1.0;
                }

                else
                {
                    _radius = value;
                }
            }
        }


        public Circle()
        {
            Center = new Point();
            Radius = 1.0;
        }

        public Circle(double iRadius)
        {
            Center = new Point();
            Radius = iRadius;
        }

        public Circle(double iX, double iY, double iRadius)
        {
            Center = new Point(iX, iY);
            Radius = iRadius;
        }

        public Circle(Circle iCircle)
        {
            Center = iCircle.Center;
            Radius = iCircle.Radius;
        }

        public void setCiricle(double ix, double iy, double iraduis)
        {
            Center = new Point(ix, iy);
            Radius = iraduis;
        }

        public virtual double getArea()
        {
            return Math.PI * (Radius * Radius) ;
        }

        //[Circle: center(0,0), radius=1, area=3.14159265358979]

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}",Center.X,Center.Y,Radius,getArea());
        }

    }
}

