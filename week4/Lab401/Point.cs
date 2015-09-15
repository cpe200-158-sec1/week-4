using System;

namespace Lab4
{
	public class Point
	{
		private double _x , _y;

		//propeties
		public double x {
			get { return _x; }
			set { _x = value; }
		}
		public double y {
			get { return _y; }
			set{ _y = value; }
		}


		//constructor
		public Point()
		{
			x = 0.0;
			y = 0.0;
		}
		public Point(double xx , double yy)
		{
			x = xx;
			y = yy;
		}
		public Point(Point a)
		{
			x = a.x;
			y = a.y;
		}

		//Methods
		public override string ToString()
		{
			return String.Format ("center({0},{1})", x, y);
		}
			

	}
}
