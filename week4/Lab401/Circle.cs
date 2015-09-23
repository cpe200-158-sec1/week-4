using System;

namespace Lab4
{
    public class Circle : Point
    {
        private Point _Center;
        private double _Radius;

        public Point Center
        {
            get { return _Center; }
            set { _Center = value; }
        }

        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                }

                else
                {
                    _Radius = 1.0;
                }
            }
        }

        public Circle() : base()
        {
            // _Center = new Point() ;
            _Radius = 1.0;
        }

        public Circle(double r) : base()
        {
            // _Center = new Point();
            _Radius = r;
        }

        public Circle(double X, double Y, double r) : base(X, Y)
        {
            // _Center = new Point(X, Y);
            _Radius = r;
        }

        public Circle(Circle a) : base(a.X, a.Y)
        {
            //_Center = new Point(a.Center);
            _Radius = a.Radius;
        }

        public void setCircle(double X, double Y, double r)
        {
            this._Center = new Point(X, Y);
            this._Radius = r;
        }

        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle: cente({0},{1}), radius={2}, area={3}]", X, Y, _Radius, getArea());
        }
    }
}