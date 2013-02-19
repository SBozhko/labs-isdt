using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_trinagle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creation of new triangle...");
            Triangle triangle = new Triangle();
            triangle.Coordinates = new double[,] {{1, 1}, {1, 5}, {4, 1}};
            Console.WriteLine(triangle);

            Console.WriteLine("Resizing... x *= 4; y *= 4");
            triangle.Resize(4, 4);
            Console.WriteLine(triangle);

            int degrees = 60;
            Triangle.Clockwise clockwise = Triangle.Clockwise.TRUE;
            Console.WriteLine("Rotating... clockwise = " + clockwise + "; degrees = " + degrees);
            triangle.Rotate(60, Triangle.Clockwise.TRUE);
            Console.WriteLine(triangle);

            int xOffset = 4;
            int yOffset = 3;
            Console.WriteLine("Moving..." + "xOffset = " + xOffset + "; yOffset = " + yOffset);
            triangle.Move(xOffset, yOffset);
            Console.WriteLine(triangle);

            Console.ReadKey();
        }
    }
}
