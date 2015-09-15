using System;

namespace Lab4
{
	public abstract class Shape
	{
        public string _Color="gold";


        public string Color
        {
            get { return _Color; }
        }
		public Shape (string c)
		{
            _Color = c;
		}

	}
}

