using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_trinagle
{
    class Triangle
    {
        private const int VERTICES = 3;
        private readonly int DIMENTIONS = 2; // 2D triangle by default
        public double[,] Coordinates
        {
            set; get;
        }
        public enum CLOCKWISE { TRUE, FALSE }

        public Triangle()
        {
            Coordinates = new double[VERTICES, DIMENTIONS];
        }

        public Triangle(int numberOfDimentions)
        {
            DIMENTIONS = numberOfDimentions;
            Coordinates = new double[VERTICES, DIMENTIONS];
        }

        public void Move(double xOffset, double yOffset)
        {
            for (int i = 0; i < VERTICES; i++)
            {
                Coordinates[i, 0] += xOffset;
                Coordinates[i, 1] += yOffset;
            }
        }

        public void Rotate(double degrees, CLOCKWISE clockwiseFlag)
        {
            double radians = Math.PI * degrees / 180;
            int clockwiseIndex = 1;
            if (clockwiseFlag == CLOCKWISE.FALSE)
            {
                clockwiseIndex = -1;
            }

            for (int i = 0; i < VERTICES; i++)
            {
                Coordinates[i, 0] = Coordinates[i, 0] * Math.Cos(radians) + clockwiseIndex * Coordinates[i, 1] * Math.Sin(radians);
                Coordinates[i, 1] = Coordinates[i, 1] * Math.Cos(radians) - clockwiseIndex * Coordinates[i, 0] * Math.Sin(radians);
            }
        }

        public void Resize(double xMultiplier, double yMultiplier)
        {
            for (int i = 1; i < VERTICES; i++)
            {
                Coordinates[i, 0] = Coordinates[i, 0] * xMultiplier;
                Coordinates[i, 1] = Coordinates[i, 1] * yMultiplier;
            }
        }

        public override string ToString()
        {
            checkTriangleSides(Coordinates);

            StringBuilder triangleInfo = new StringBuilder("Triangle's information: " + DIMENTIONS + "D\n");
            for (int i = 0; i < VERTICES; i++)
            {
                triangleInfo.Append("Coordinates of the vertex " + (i + 1) + ": (");
                for (int j = 0; j < DIMENTIONS; j++)
                {
                    triangleInfo.Append(String.Format("{0:#,0.##}", Math.Round(Coordinates[i, j], 2)));

                    if (j < DIMENTIONS - 1)
                    {
                        triangleInfo.Append(", ");
                    }
                }
                triangleInfo.Append(")\n");
            }
            return triangleInfo.ToString();
        }

        private bool checkTriangleSides(double[,] coordinates) 
        {
            double side1, side2, side3;

            side1 = Math.Sqrt(Math.Pow(coordinates[0, 0] - coordinates[1, 0], 2) + Math.Pow(coordinates[0, 1] - coordinates[1, 1], 2));
            side2 = Math.Sqrt(Math.Pow(coordinates[1, 0] - coordinates[2, 0], 2) + Math.Pow(coordinates[1, 1] - coordinates[2, 1], 2));
            side3 = Math.Sqrt(Math.Pow(coordinates[2, 0] - coordinates[0, 0], 2) + Math.Pow(coordinates[2, 1] - coordinates[0, 1], 2));

            Console.WriteLine("side1: " + side1);
            Console.WriteLine("side2: " + side2);
            Console.WriteLine("side3: " + side3);

            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                Console.WriteLine("checkTriangleSides: " + false);
                return false;
            }

            Console.WriteLine("checkTriangleSides: " + true);

            return true;   
        }        
    }
}
