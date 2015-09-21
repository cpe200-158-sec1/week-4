using System;

namespace Lab4
{
	public class Circle : Point

	{
        private double _Radius;
    
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public Circle ()
		{
            x = 0.0;
            y = 0.0;
            Radius = 1.0;
		}
        public Circle (double R )
        {
            Radius = R;
        }
        public Circle(double ix , double iy , double R)
        {
            x = ix;
            y = iy;
            Radius = R;
        }
        public Circle(Circle C)
        {
            x = C.x;
            y = C.y;
            Radius = C.Radius;

        }
        public void setCircle(double ix , double iy , double R)
        {
            x = ix;
            y = iy;
            Radius = R;
        }
        public virtual double getArea ()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return String.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.x, this.y, this.Radius, this.getArea()) ;
        }
    }
}

