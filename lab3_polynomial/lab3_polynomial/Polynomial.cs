using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_polynomial
{
    class Polynomial
    {
        private readonly int degree;
        public double[] Coefficients { set; get; }

        public Polynomial(int degree, double[] coefficients)
        {
            if (degree + 1 != coefficients.Length)
            {
                // TODO exception
            }

            this.degree = degree;
            this.Coefficients = coefficients;
        }

        public double Calculate(double x)
        {
            double result = 0;
            double tmpX = 1;
            for (int i = Coefficients.Length - 1; i >= 0; i--)
            {                
                result += Coefficients[i] * tmpX;
                tmpX *= x;                                                                           
            }

            return result;
        }

    }
}
