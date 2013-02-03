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
            triangle.print();           
            triangle.Resize(4, 4);
            triangle.Rotate(60, Triangle.CLOCKWISE.TRUE);
            triangle.Move(4, 3);
            triangle.print();

            Console.ReadKey();
        }
    }
}
