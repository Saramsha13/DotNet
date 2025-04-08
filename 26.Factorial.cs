using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Factorial
    {
        public int fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * fact(n - 1);
        }
    }
}
