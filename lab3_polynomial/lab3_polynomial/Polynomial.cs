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
            double xDegree = 1;
            for (int i = Coefficients.Length - 1; i >= 0; i--)
            {                
                result += Coefficients[i] * xDegree;
                xDegree *= x;                                                                           
            }

            return result;
        }

        public double GetCoefficient(int index)
        {
            if (index <= 0 || index > Coefficients.Length)
            { 
                // TODO exception
            }
            return Coefficients[index - 1];
        }

        public string ToHumanString()
        {
            StringBuilder sb = new StringBuilder(base.ToString() + "\n");
            int xDegree = this.degree;
            for (int i = 0; i < Coefficients.Length; i++)
            {

                string coeffStr = (Coefficients[i] != 1 && Coefficients[i] != 0) ? Coefficients[i].ToString() : "";
               
                string xDegreeStr = (xDegree != 0 && xDegree != 1) ? "x^" + xDegree.ToString() : "";
                xDegreeStr = (xDegree == 1) ? "x" : xDegreeStr;
                xDegreeStr = (Coefficients[i] == 0) ? "" : xDegreeStr;

                sb.Append(coeffStr + xDegreeStr);
                sb.Append((i < Coefficients.Length - 1 && Coefficients[i] != 0) ? " + " : "");
                xDegree--;
            }
            
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString() + "\n");
            int xDegree = this.degree;
            for (int i = 0; i < Coefficients.Length; i++)
            {
                sb.Append(Coefficients[i] + "x^" + xDegree);
                sb.Append((i < Coefficients.Length - 1) ? " + " : "");
                xDegree--;
            }

            return sb.ToString();
        }



    }
}
