using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_trinagle
{
    class IllegalArgumentException : Exception
    {
        private string p;

        public IllegalArgumentException(string p)
        {            
            this.p = p;
        }
    }
}
