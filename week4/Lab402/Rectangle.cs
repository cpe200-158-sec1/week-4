using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
		private double _height, _width;


		//propeties
		public double width {
			get{ return _width; }
			set{ _width = (value >= 0) ? value : 1.00; }
		}
		public double height {
			get{ return _height; }
			set{ _height = (value >= 0) ? value : 1.00; }
		}
		public override string color
		{
			get{ return _color;}
		}


		// constructor
		public Rectangle ()
		{
			width = 1.00;
			height = 1.00;
			_color = "gold";
		}
		public Rectangle(string c,double w ,double h)
		{
			width = w;
			height = h;
			_color = c;
		}
		
		public Rectangle (Rectangle a)
		{
			width = a.width;
			height = a.height;
			_color = a.color;
		}

		//method
		public override double getArea()
		{
			return this.width * this.height;
		}
		public override double getPerimeter()
		{
			return (this.width * 2) + (this.height * 2);
		}



		public override string ToString ()
		{
			return string.Format ("[Rectangle: width={0}, height={1}, area={2}, color={3}]",
				this.width, this.height, this.getArea(), this.color);
			
		} 








	}
}

