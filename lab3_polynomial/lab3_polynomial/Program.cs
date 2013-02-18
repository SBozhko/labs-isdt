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
            Polynomial p = new Polynomial(4, new double[] {2, 1, 2, 5, 4});
            Console.WriteLine(p.Calculate(1));
            Console.WriteLine(p.Calculate(2));
            Console.ReadKey();
        }
    }
}
