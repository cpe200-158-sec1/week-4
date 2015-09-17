using System;

namespace Lab4
{
	public class Triangle :Shape
	{
		private double _height , _width;

		// propeties
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
			get { return _color; }
		}


		//constructor
		public Triangle()
		{
			width = 1.00;
			height = 1.00;
			_color = "Gold";
		}
		public Triangle(string c,double w, double h)
		{
			width = w;
			height = h;
			_color = c;
		}
		public Triangle (Triangle a)
		{
			width = a.width;
			height = a.height;
			_color = a.color;
		}

		//method
		public override double getArea()
		{
			return 0.5 * width * height;
		}
		public override double getPerimeter()
		{
			return Math.Sqrt (this.width * this.width + this.height * this.height) + this.width + this.height; 
		}

		public override string ToString ()
		{
			return String.Format ("[Triangle: base ={0}, height={1} area = {2}, color = {3}]", 
				this.width, this.height, this.getArea(), this.color);
		}

	}
}

