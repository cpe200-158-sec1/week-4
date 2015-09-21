using System;

namespace Lab4
{
	class MainClass
	{
        public static double printPerimeter(Shape s)
        {
            return s.getPerimeter();
        }
        public static double printPerimeter(Rectangle r)
        {
            return r.getPerimeter();
        }
        public static double printPerimeter(Triangle t)
        {
            return t.getPerimeter();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main (string[] args)
		{
			Shape s1 = new Rectangle("red", 4, 5); 			Console.WriteLine (s1);  			Shape s2 = new Triangle("blue", 4, 5); 			Console.WriteLine (s2);  			Shape s3 = new Rectangle(); 			Console.WriteLine (s3);  			Rectangle r1 = new Rectangle((Rectangle)s1); 			Console.WriteLine (r1); 			r1.Width=-5.0; r1.Height=15; 			//Console.WriteLine (r1);  			Triangle t1 = new Triangle(); 			t1.Width=3; t1.Height=4; 			//Console.WriteLine (t1);


            //			Shape s4 = new Shape("green"); 
            //			Console.WriteLine (s4);

            Console.WriteLine("Perimeter of s1: " + printPerimeter(s1));
            Console.WriteLine("Perimeter of s2: " + printPerimeter(s2));
            Console.WriteLine("Perimeter of s3: " + printPerimeter(s3));
            Console.WriteLine("Perimeter of r1: " + printPerimeter(r1));
            Console.WriteLine("Perimeter of t1: " + printPerimeter(t1));
            Console.ReadLine();

		}
	}
}
