using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2_array
{
    class IllegalArgumentException : Exception
    {
        public string Summary{set; get;}

        public IllegalArgumentException(string summary)
        {
            Summary = summary;
        }
    }
}
