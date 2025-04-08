using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    internal class Parameters
    {
        public void callAll()
        {
            int a = 5, b;

            Console.WriteLine("Out Parameter:");
            OutParameter(out b); // 'b' will be assigned in the method
            Console.WriteLine($"Value of b: {b}");

            Console.WriteLine("\nRef Parameter:");
            RefParameter(ref a); // 'a' must be initialized before passing
            Console.WriteLine($"Value of a: {a}");

            Console.WriteLine("\nParams Array:");
            ParamsParameter("Hello", "World", "!");

            Console.WriteLine("\nDefault Parameters:");
            DefaultParameter(); // Uses default values
            DefaultParameter(100); // Override only one
        }

        // Out parameter
        static void OutParameter(out int x)
        {
            x = 42;
        }

        // Ref parameter
        static void RefParameter(ref int x)
        {
            x *= 2;
        }
               
        // Params (variable arguments)
        static void ParamsParameter(params string[] words)
        {
            foreach (var word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
                
        // Default parameter values
        static void DefaultParameter(int x = 5, int y = 10)
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}
