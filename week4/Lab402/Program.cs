﻿using System;

namespace Lab4

{
	class MainClass
	{
        
            public static double printPerimeter(Shape inShape)
            {
                return inShape.getPerimeter();
            }
            public static double printPerimeter(Rectangle inRectangle)
            {
                return inRectangle.getPerimeter();
            }
            public static double printPerimeter(Triangle inTriangle)
            {
                return inTriangle.getPerimeter();
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
            r1.Width = -5.0; r1.Height = 15;
            Console.WriteLine(r1);

            Triangle t1 = new Triangle();
            t1.Width = 3; t1.Height = 4;
            Console.WriteLine(t1);
              //Shape s4 = new Shape("green");
            //Console.WriteLine(s4);

            Console.WriteLine("Perimeter of s1: {0}", printPerimeter(s1));
            Console.WriteLine("Perimeter of s2: {0}", printPerimeter(s2));
            Console.WriteLine("Perimeter of s3: {0}", printPerimeter(s3));
            Console.WriteLine("Perimeter of r1: {0}", printPerimeter(r1));
            Console.WriteLine("Perimeter of t1: {0}", printPerimeter(t1));

            Console.ReadKey();
        }

        //    ## Expected Output:

        //[Rectangle: width=4, height=5, area=20, color="red"]
        //[Triangle: base=4, height=5, area=10, color="blue"]
        //[Rectangle: width=1, height=1, area=1, color="gold"]
        //[Rectangle: width=4, height=5, area=20, color="red"]
        //Perimeter s1: 18
        //Perimeter s1: 15.4031242374328
        //Perimeter s1: 4
        //Perimeter s1: 32
        //Perimeter s1: 12



    }
	
}
