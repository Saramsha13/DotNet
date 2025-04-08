using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class OddEven
    {
        public void check()
        {
            int num;
            while (true)
            {
                Console.Write("Enter a Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                    break;
                else
                    Console.WriteLine("Enter a Positive Number");
            }

            if (num % 2 == 0)
                Console.WriteLine(num + " is an Even Number");
            else
                Console.WriteLine(num + " is a Odd Number");
        }
    }
}
