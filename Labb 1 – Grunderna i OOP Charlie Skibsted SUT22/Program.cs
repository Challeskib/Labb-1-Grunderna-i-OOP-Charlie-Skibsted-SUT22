using System;

namespace Labb_1___Grunderna_i_OOP_Charlie_Skibsted_SUT22
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);

            circle1.GetArea();
            circle1.GetCircumference();

            Console.WriteLine();

            Circle circle2 = new Circle(6);

            circle2.GetArea();
            circle2.GetCircumference();

            Console.WriteLine();

            Circle circle3 = new Circle(5, 5);
            circle3.GetArea();
            circle3.GetCircumference();
            circle3.GetCircleVolume();

            Console.WriteLine();

            Triangle triangle1 = new Triangle(5, 5);
            triangle1.GetTriangleArea();
        }
    }
}
