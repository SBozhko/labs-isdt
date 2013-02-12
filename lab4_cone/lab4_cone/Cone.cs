using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4_cone
{
    public class Cone
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Density { get; set; }
        public double Volume { get { return Math.PI * Math.Pow(Radius, 2) * Height / 3; } set { this.Volume = value; } }
        public double Mass { get { return Volume * Density; } set { this.Mass = value; } }

        public Cone()
        {
            string lines = "public Cone()";
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
            file.WriteLine(lines);
            
        }
    }
}
