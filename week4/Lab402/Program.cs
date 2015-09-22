using System;
using Lab4;

namespace Lab4
{
    class MainClass
    {
        public static double printPerimeter(Shape s)
        {
            return s.getPerimeter();
        }

        public static double printPerimeter(Rectangle a)
        {
            return a.getPerimeter();
        }
        public static double printPerimeter(Triangle b)
        {
            return b.getPerimeter();
        }

        public static void Main(string[] args)
        {
            Shape s1 = new Rectangle("red", 4, 5);
            Console.WriteLine(s1);

            Shape s2 = new Triangle("blue", 4, 5);
            Console.WriteLine(s2);

            Shape s3 = new Rectangle();
            Console.WriteLine(s3);

            Rectangle r1 = new Rectangle((Rectangle)s1);
            Console.WriteLine(r1);
            r1.width = -5.0; r1.height = 15;
            Console.WriteLine(r1);

            Triangle t1 = new Triangle();
            t1.width = 3; t1.height = 4;
            Console.WriteLine(t1);

            //			Shape s4 = new Shape("green"); 
            //			Console.WriteLine (s4);

            Console.WriteLine("Perimeter of s1: {0}", printPerimeter(s1));
            Console.WriteLine("Perimeter of s2: {0}", printPerimeter(s2));
            Console.WriteLine("Perimeter of s3: {0}", printPerimeter(s3));
            Console.WriteLine("Perimeter of r1: {0}", printPerimeter(r1));
            Console.WriteLine("Perimeter of t1: {0}", printPerimeter(t1));
            Console.ReadKey();
        }
    }
}
