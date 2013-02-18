using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p = new Polynomial(4, new double[] {2, 3, 1, 4, 5});
            Console.WriteLine(p);
            Polynomial p1 = new Polynomial(3, new double[] { 2, 3, 1, 4});
            Polynomial p2 = new Polynomial(2, new double[] { 3, 1, 2});
            //Console.WriteLine(p.Calculate(1));
            Console.WriteLine("*************");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("*************");

            //Console.WriteLine(p1 + p2);

            Console.WriteLine("*************");

            Console.WriteLine(p2 - p1);

            Console.WriteLine("*************");

            Console.WriteLine(p1 * p2);
            Console.ReadKey();
        }
    }
}
