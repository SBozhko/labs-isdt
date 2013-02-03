using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_trinagle
{
    class Triangle
    {
        private const int VERTICES = 3;
        private const int DIMENTIONS = 2; // 2D triangle
        private double[,] coordinates = new double[VERTICES, DIMENTIONS];
        public enum CLOCKWISE {TRUE, FALSE}

        public Triangle()
        {
            // Pascal's triangle
            coordinates[0, 0] = 1;
            coordinates[0, 1] = 1;
            coordinates[1, 0] = 4;
            coordinates[1, 1] = 1;
            coordinates[2, 0] = 1;
            coordinates[2, 1] = 5;
        }
        
        public double[,] getCoordinates()
        {
            return this.coordinates;
        }

        public void setCoordinates(double[,] coordinates)
        {
            this.coordinates = coordinates;
        }
                
        public void Move(double dx, double dy)
        {
            for (int i = 0; i < VERTICES; i++ )
            {
                coordinates[i, 0] += dx;
                coordinates[i, 1] += dy;
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
                coordinates[i, 0] = coordinates[i, 0] * Math.Cos(radians) + clockwiseIndex * coordinates[i, 1] * Math.Sin(radians);
                coordinates[i, 1] = coordinates[i, 1] * Math.Cos(radians) - clockwiseIndex * coordinates[i, 0] * Math.Sin(radians);
            }
        }

        public void Resize(double xRatio, double yRatio)
        {
            for (int i = 1; i < VERTICES; i++)
            {
                coordinates[i, 0] = coordinates[i, 0] * xRatio;
                coordinates[i, 1] = coordinates[i, 1] * yRatio;
            }
        }

        public void print()
        {
            for (int i = 0; i < VERTICES; i++)
            {
                for (int j = 0; j < DIMENTIONS; j++)
                {
                    Console.Write(coordinates[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
