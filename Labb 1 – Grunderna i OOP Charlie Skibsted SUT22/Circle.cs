using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Grunderna_i_OOP_Charlie_Skibsted_SUT22
{
    class Circle
    {

        public float pi = 3.141f;
        public float radius;
        public float height;


        public Circle(float Radius)
        {
            radius = Radius;
        }

        public Circle(float Radius, float Height) //Overload på constructer med en extra parameter
        {
            radius = Radius;
            height = Height;
        }

        public void GetArea()
        {
            Console.WriteLine($"Arean på denna cirkeln är: {pi*radius*radius} areaenheter");
        }
        public void GetCircumference()
        {
            Console.WriteLine($"Omkretsen på denna cirkeln är: {pi * (radius + radius)} längdenheter");
        }
        public void GetCircleVolume()
        {
            Console.WriteLine($"Volymen på denna cirkeln är: {pi * radius * radius * height} kubikenheter");
        }

    }
}
