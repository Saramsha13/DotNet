using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Mulitply
    {
        public void calc(int n)
        {
            int num = n;
            Console.WriteLine("Multiplication Table of " + num);
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }
        public void multiTable1()
        {
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Multiplication Table of " + j);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(j + " * " + i + " = " + j * i);
                }
                Console.WriteLine("");
            }
        }

        public void multiTable2()
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(j + " * " + i + " = " + j * i +"\t");
                }
                Console.WriteLine("");
            }
        }

        public void multiTable3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Table of " + i + "\t");
            }
            Console.WriteLine("");

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + " * " + j + " = " + j * i + "\t");
                }
                Console.WriteLine("");
            }
        }

        public void fullTable()
        {
            Console.WriteLine("\t \t \t \t \t Mulitplication Table\n");

            Console.Write(" \t | \t");
            for (int z = 1; z <= 10; z++)
            {
                Console.Write(z + "\t");
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t | \t");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
