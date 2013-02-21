using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creation new array...");
            Array array = new Array(new int[] { 4, 5, -6, 0, 6, 1, 0, 6, 7, 0, 4});
            Console.WriteLine("Array: " + array);
            Console.WriteLine("Production of array items with even indexes: " + array.GetEvenIndexItemsProduction());
            try
            {
                Console.WriteLine("Summa of array items between the first and the last zeros: " + array.GetSumBetweenFirstAndLastZeros());
            }
            catch (IllegalArgumentException e)
            {
                Console.WriteLine(e.Summary);
            }
            array.Transform();
            Console.WriteLine("Transformed array. At first itemns >= 0 then items < 0:\n" + array);
            Console.ReadKey();
        }
    }
}
