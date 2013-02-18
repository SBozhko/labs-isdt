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
            Polynomial p = new Polynomial(4, new double[] { 2, -3, 1, 4, 5 });

            Console.WriteLine("Creation new polynomial...");
            Console.WriteLine(p);
            Console.WriteLine("Human string: " + p.ToHumanString());
            Console.WriteLine();

            int x = 5;
            Console.WriteLine("Calculating polynomial. x = " + x);
            Console.WriteLine("Result = " + p.Calculate(x));
            Console.WriteLine();

            int index = 3;
            Console.WriteLine("Getting coefficient...\nIndex of coefficient = " + index);
            Console.WriteLine("Result = " + p.GetCoefficient(index));
            Console.WriteLine();

            Polynomial p1 = new Polynomial(3, new double[] { 2, 3, 1, 4 });
            Polynomial p2 = new Polynomial(2, new double[] { 3, 1, 2 });

            Console.WriteLine("Creation p1");
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.WriteLine("Creation p2");
            Console.WriteLine(p2);
            Console.WriteLine();

            Console.WriteLine("Test: p1 + p2");
            Console.WriteLine("Result: " + (p1 + p2));
            Console.WriteLine();

            Console.WriteLine("Test: p2 - p1");
            Console.WriteLine("Result: " + (p2 - p1));
            Console.WriteLine();

            Console.WriteLine("Test: p1 * p2");
            Console.WriteLine("Result: " + (p1 * p2));
            Console.ReadKey();
        }
    }
}
