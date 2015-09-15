using System;

namespace Lab4
{
	public class Cylinder :Circle
	{
		private double _height;

		//Properties
		public double height
		{ 
			get{ return _height;}
			set{ _height = (value >= 0)? value : 1.00 ;}
		} 


		//Constructor
		public Cylinder()
		{
			height = 1.00;
			radius = 1.00;
			x = 0.00;
			y = 0.00;
		}
		public Cylinder(double r, double h)
		{
			height = h;
			radius = r;
			x = 0.00;
			y = 0.00;
		}
		public Cylinder(double xx ,double yy ,double r ,double h)
		{
			height = h;
			radius = r;
			x = xx;
			y = yy;
		}
		public Cylinder(Circle a)
		{
			height = 1.00;
			radius = a.radius;
			x = a.x;
			y = a.y;
		}
		public Cylinder(Cylinder a)
		{
			height = a.height;
			radius = a.radius;
			x = a.x;
			y = a.y;
		}

		//method

		public override double getArea()
		{
			return (2.00 * Math.PI * radius * height) + (2.00 * Math.PI * radius * radius);
		}
		public double getVolume()
		{
			return Math.PI * radius * radius * height;
		}
		public override string ToString()
		{
			return String.Format ("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]"
				, this.x, this.y, this.radius, this.height, this.getArea (), this.getVolume ());

		
		}

			


 		
		
	}

}
