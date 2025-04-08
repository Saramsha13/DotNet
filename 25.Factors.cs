using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factors
    {
        public void calcluateFactors()
        {
            int num;
            while (true)
            {
                Console.Write("Enter a Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 1)
                    break;
                else
                    Console.WriteLine("Enter a Positive Number");
            }

            Console.Write("Factors of " + num + " are: ");
            for (int i = 1; i <= Math.Floor(Convert.ToDecimal(num / 2)); i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Write(num+"\n");
        }
    }
}
