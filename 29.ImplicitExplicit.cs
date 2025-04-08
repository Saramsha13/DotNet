using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    internal class ImpExplicit
    {
        public void Convert() 
        {
            // Implicit conversion
            int a = 10;
            double b = a; // int to double
            Console.WriteLine($"Implicit conversion: {a} to {b}");
            
            // Explicit conversion
            double c = 9.78;
            int d = (int)c; // double to int
            Console.WriteLine($"Explicit conversion: {c} to {d}");
            
            // Using Convert class
            string str = "123";
            int e = Convert.ToInt32(str);
            Console.WriteLine($"Convert class: {str} to {e}");
        }
    }
}
