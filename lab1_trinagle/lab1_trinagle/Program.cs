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
            Triangle triangle = new Triangle();
            triangle.Coordinates = new double[,] {{1, 1}, {4666.4565, 256545.5456}, {0, 5}};
            

            Console.WriteLine(triangle.ToString());
            triangle.Resize(4, 4);
            triangle.Rotate(60, Triangle.CLOCKWISE.TRUE);
            triangle.Move(4, 3);
            Console.WriteLine(triangle.ToString());

            Console.ReadKey();
        }
    }
}
