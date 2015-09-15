# Lab402: Shape abstract class, Retangle and Triangle classes

# 1. Shape Class:
Abstract class

## Propeties:
- string Color: read-only, color of the shape, default="gold"

## Constructors:
- no default constructor
- Shape(string): takes color as a parameter

## Methods
- overriding ToString()
- getArea(): abstract method, calculate area of the shape
- getPerimeter(): abstract method, calculate perimeter of the shape

# 2. Rectangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Rectangle(): default
- Rectangle(string,double,double): takes color,width,height as parameters
- Rectangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a rectangle
- override ToString() method

# 3. Triangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Triangle(): default
- Triangle(string,double,double): takes color,width,height as parameters
- Triangle(Triangle): copy constructor

## Methods:
- getArea(): get area of a triangle
- override ToString() method

## Questions:

1. Are there still any redundant lines of code in your project? where?
> **Answer:** I found redundant lines of code in constructors.
2. Modify the project so that you can minimize or solve those redundancy.
> **Answer:** We can call specific base constructors by using the base keyword after a colon in each constructors. This is the way to reduce the redundant codes of construction Shape _color attribute.
3. What happen if you uncomment line #27-28 in the Program.cs file? Why?
> **Answer:** It causes errors because Shape is abstract class. That means we do not implement the class members yet. We can not directly use Shape class to instantiate object by itself.
4. If you uncomment line #30-24 in the Program.cs file, you will get some compile errors.
   Modify the classes and/or the program.cs without touching the "Main" method so that 
   the program will display the result as shown below:
> **Answer:** I implemented 3 printPerimeter methods (with overloading) that we can use printPerimeter() to show perimeter inside the MainClass but outside the Main method. These methods get perimeter from its own object.

## Expected Output:

[Rectangle: width=4, height=5, area=20, color="red"]
[Triangle: base=4, height=5, area=10, color="blue"]
[Rectangle: width=1, height=1, area=1, color="gold"]
[Rectangle: width=4, height=5, area=20, color="red"]
Perimeter s1: 18
Perimeter s1: 15.4031242374328
Perimeter s1: 4
Perimeter s1: 32
Perimeter s1: 12

