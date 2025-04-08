using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    internal class Fibo
    {
        public void fibonacci(int n)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci Series:");
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }

        public int fiboRecursion(int n)
        {
            if (n == 0)
                return(0);
            else if (n == 1)
                return(1);
            else
                return(fiboRecursion(n - 1) + fiboRecursion(n - 2));
        }

        public void fibRecursion(int n)
        {
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fiboRecursion(i) + " ");
            }
        }
    }
}
