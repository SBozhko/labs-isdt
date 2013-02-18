using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_trinagle
{
    class Triangle
    {
        private const byte CORNERS = 3;
        private readonly byte DIMENTIONS = (byte)DIMENTION._2D; // 2D triangle by default
        public double[,] Coordinates
        {
            set; get;
        }
        public enum CLOCKWISE { TRUE, FALSE };
        public enum DIMENTION : byte { _2D = 2, _3D = 3 };

        public Triangle()
        {
            Coordinates = new double[CORNERS, DIMENTIONS];
        }

        public Triangle(DIMENTION dimention)
        {
            DIMENTIONS = (byte)dimention;
            Coordinates = new double[CORNERS, DIMENTIONS];
        }

        public void Move(double[] coordinatesOffset )
        {
            if (DIMENTIONS != coordinatesOffset.Length)
            {
                throw new IllegalArgumentException("The number of dimensions should be equal the number of coordinates offsets");
            }

            for (int i = 0; i < CORNERS; i++)
            {
                for (int j = 0; j < DIMENTIONS; j++)
                {
                    Coordinates[i, j] += coordinatesOffset[j];
                }
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

            for (int i = 0; i < CORNERS; i++)
            {
                Coordinates[i, 0] = Coordinates[i, 0] * Math.Cos(radians) + clockwiseIndex * Coordinates[i, 1] * Math.Sin(radians);
                Coordinates[i, 1] = Coordinates[i, 1] * Math.Cos(radians) - clockwiseIndex * Coordinates[i, 0] * Math.Sin(radians);
            }
        }

        public void Resize(double[] coordinatesMultipliers)
        {
            if (DIMENTIONS != coordinatesMultipliers.Length)
            {
                throw new IllegalArgumentException("The number of dimensions should be equal the number of coordinates offsets");
            }

            for (int i = 1; i < CORNERS; i++)
            {
                for (int j = 0; j < DIMENTIONS; j++)
                {
                    Coordinates[i, 0] *= coordinatesMultipliers[j];                    
                }
            }
        }

        public override string ToString()
        {
            checkTriangleSides(Coordinates);

            StringBuilder triangleInfo = new StringBuilder("Triangle's information: " + DIMENTIONS + "D\n");
            for (int i = 0; i < CORNERS; i++)
            {
                triangleInfo.Append("Coordinates of the corner " + (i + 1) + ": (");
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
