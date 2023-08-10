using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class MathOperations
    {

        public int  Add(int n, int m)
        {
            return n + m;
        }
        public  double Add(double n, double m, double r)
        {
            return n + m+r;
        }
        public decimal Add(decimal n, decimal m, decimal r)
        {
            return n + m + r;
        }
    }
}
