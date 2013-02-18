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
                throw new IndexOfBoundException();
            }

            this.degree = degree;
            this.Coefficients = coefficients;
        }

        public Polynomial(Polynomial polynomial)
        {
            this.degree = polynomial.degree;
            this.Coefficients = new double[polynomial.Coefficients.Length];
            for (int i = 0; i < polynomial.Coefficients.Length; i++)
            {
                this.Coefficients[i] = polynomial.Coefficients[i];
            }
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
                throw new IndexOfBoundException();
            }
            return Coefficients[index - 1];
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            int p1Degree = p1.degree;
            int p2Degree = p2.degree;
            int pesultDegree = p1Degree + p2Degree;
            double[] resultCoeffs = new double[pesultDegree + 1];

            for (int i = 0; i < p1.Coefficients.Length; i++)
            {
                for (int j = 0; j < p2.Coefficients.Length; j++)
                {
                    resultCoeffs[pesultDegree - (p1Degree + p2Degree--)] += p1.Coefficients[i] * p2.Coefficients[j];
                }
                p1Degree--;
                p2Degree = p2.degree;
            }

            return new Polynomial(pesultDegree, resultCoeffs);
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            int p1Degree = p1.degree;
            int p2Degree = p2.degree;
            int pesultDegree = Math.Max(p1Degree, p2Degree);
            double[] resultCoeffs = new double[pesultDegree + 1];
            int j = resultCoeffs.Length - 1;

            for (int i = p1.degree; i >= 0; i--)
            {
                resultCoeffs[j--] += p1.Coefficients[i];
            }

            j = resultCoeffs.Length - 1;
            for (int i = p2.degree; i >= 0; i--)
            {
                resultCoeffs[j--] += p2.Coefficients[i];
            }

            return new Polynomial(pesultDegree, resultCoeffs);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            Polynomial p2Negative = new Polynomial(p2);

            for (int i = 0; i < p2Negative.Coefficients.Length; i++)
            {
                p2Negative.Coefficients[i] *= -1;
            }

            return p1 + p2Negative;
        }

        public string ToHumanString()
        {
            StringBuilder sb = new StringBuilder();
            int xDegree = this.degree;
            string signStr = "";
            string coeffStr = "";
            string xDegreeStr = "";

            for (int i = 0; i < Coefficients.Length; i++)
            {
                signStr = Coefficients[i] < 0 ? " - " : signStr = " + ";
                signStr = i == 0 ? signStr.Substring(1, 2) : signStr;
                signStr = (i == 0 && Coefficients[i] >= 0) ? "" : signStr;

                coeffStr = (Coefficients[i] != 1 && Coefficients[i] != 0) ? Math.Abs(Coefficients[i]).ToString() : "";

                xDegreeStr = (xDegree != 0 && xDegree != 1) ? "x^" + xDegree.ToString() : "";
                xDegreeStr = (xDegree == 1) ? "x" : xDegreeStr;
                xDegreeStr = (Coefficients[i] == 0) ? "" : xDegreeStr;

                sb.Append(signStr + coeffStr + xDegreeStr);
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
                sb.Append(Math.Abs(Coefficients[i]) + "x^" + xDegree--);
            }

            return sb.ToString();
        }




    }
}
