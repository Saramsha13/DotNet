using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Pattern
    {
        public void createNormal()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public void createNumberedi()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

        }

        public void createNumberedj()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        public void createLoweredNumberedj()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        public void createReverse()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j > 5-i; j--)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public void createReverseNumbered()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
    