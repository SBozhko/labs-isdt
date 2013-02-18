using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_polynomial
{
    class Polynomial
    {
        private readonly int degree;
        public int Degree
        {
            get { return this.degree; }
        }
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

        public Polynomial(Polynomial polynomial)
        {
            this.degree = polynomial.degree;
            this.Coefficients = polynomial.Coefficients;
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

        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            int p1Degree = a.degree;
            int p2Degree = b.degree;
            int newDegree = p1Degree + p2Degree;
            double[] coeffArray = new double[newDegree + 1];

            for (int i = 0; i < a.Coefficients.Length; i++)
            {
                for (int j = 0; j < b.Coefficients.Length; j++)
                {
                    coeffArray[newDegree - (p1Degree + p2Degree--)] += a.Coefficients[i] * b.Coefficients[j];
                }
                p1Degree--;
                p2Degree = b.degree;
            }

            return new Polynomial(newDegree, coeffArray);
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            int p1Degree = a.degree;
            int p2Degree = b.degree;
            int newDegree = Math.Max(p1Degree, p2Degree);
            double[] coeffArray = new double[newDegree + 1];
            int j = coeffArray.Length - 1;

            for (int i = a.degree; i >= 0; i--)
            {
                coeffArray[j--] += a.Coefficients[i];
            }

            j = coeffArray.Length - 1;
            for (int i = b.degree; i >= 0; i--)
            {
                coeffArray[j--] += b.Coefficients[i];
            }

            return new Polynomial(newDegree, coeffArray);
        }

        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            Polynomial p = new Polynomial(b);

            for (int i = 0; i < p.Coefficients.Length; i++)
            {
                p.Coefficients[i] *= -1;
            }
            
            return a + p;
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
            StringBuilder sb = new StringBuilder();
            int xDegree = this.degree;
            for (int i = 0; i < Coefficients.Length; i++)
            {
                sb.Append(Coefficients[i] >= 0 ? " + " : " - ");
                sb.Append((Coefficients[i] >= 0) ? Coefficients[i].ToString() : (-1 * Coefficients[i]).ToString() + "x^" + xDegree--);                
            }

            return sb.ToString();
        }




    }
}
