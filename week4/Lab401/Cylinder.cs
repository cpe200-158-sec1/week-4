using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
		public Cylinder ()
		{
            x = 0.0;
            y = 0.0;
            Radius = 1.0;
            Height = 1.0;
		}
        public Cylinder (double R , double H )
        {
            x = 0.0;
            y = 0.0;
            Radius = R;
            Height = H;

        }
        public Cylinder (double ix ,double iy , double R , double H)
        {
            x = ix;
            y = iy;
            Radius = R;
            Height = H;

        }
        public Cylinder (Cylinder C)
        {
            x = C.x;
            y = C.y;
            Radius = C.Radius;
            Height = C.Height;

        }
        public Cylinder (Circle C)
        {
            x = C.x;
            y = C.y;
            Radius = C.Radius;
            Height = 1.0 ;
        }
        public override double getArea()
        {
            return 2 * Math.PI * Radius * Radius + 2 * Math.PI * Radius * Height;
        }
        public double getVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
        public override string ToString()
        {
            return String.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.x, this.y, this.Radius, this.Height, this.getArea(), this.getVolume());
        }
    }
}

