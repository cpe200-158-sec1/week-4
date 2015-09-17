using System;

namespace Lab4
{
	public class Circle :Point
	{
		private double _radius;

		//Properties
		public double radius { get { return _radius; } set { _radius = (value >= 0) ? value : 1.0; } }


		//Constructors
		public Circle()
		{
			radius = 1.0;
			x = 0.0;
			y = 0.0;
		}
		public Circle(double r)
		{
			radius = r;
			x = 0.0;
			y = 0.0;
		}
		public Circle(double xx , double yy , double r)
		{
			radius = r;
			x = xx;
			y = yy;
		}
		public Circle(Circle a)
		{
			radius = a.radius;
			x = a.x;
			y = a.y;

		}
			

		//Methods

		public void setCircle(double xx, double yy, double r)
		{
			radius = r;
			x = xx;
			y = yy;

		}
		public virtual double getArea()
		{
			return (22.00 / 7.00) * radius * radius;
		}
		public override string ToString()
		{ return String.Format ("[Circle: center({0},{1}), radius={2}, area={3}]", this.x ,this.y ,this.radius , this.getArea()); }

				
			

	
}
}


