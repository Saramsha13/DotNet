using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Prime
    {
        public void calcluatePrime()
        {
            int num;
            while (true)
            {
                Console.Write("Enter a Number Fast: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 1)
                    break;
                else
                    Console.WriteLine("Enter a Positive Number");
            }
            int prime = 0;
            for (int i = 2; i <= Math.Floor(Convert.ToDecimal(num / 2)); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Composite Number ");
                    prime = 1;
                    break;
                }

            }
            if (prime == 0)
            {
                Console.WriteLine("Prime Number ");

            }
        }
    }
}
