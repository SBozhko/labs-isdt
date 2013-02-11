using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4_cone
{
    class Cone
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Density { get; set; }
        public double Volume { get { return Math.PI * Math.Pow(Radius, 2) * Height / 3;} }
        public double Mass { get { return Volume * Density;} }

        public Cone()
        { 
        }
    }
}
