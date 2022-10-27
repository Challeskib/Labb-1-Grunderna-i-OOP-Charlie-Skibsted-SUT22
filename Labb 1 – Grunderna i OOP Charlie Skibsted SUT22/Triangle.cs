using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Grunderna_i_OOP_Charlie_Skibsted_SUT22
{
    class Triangle
    {
        public float bas;
        public float height;

        public Triangle(float Bas, float Height)
        {
            bas = Bas;
            height = Height;
        }

        public void GetTriangleArea()
        {
            Console.WriteLine($"Arean på denna triangeln är: {bas*height/2} areaenheter");
        }


    }
}
