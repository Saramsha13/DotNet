using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Jackpot
    {
        int cash = 0;
        public void SpinOnce()
        {
            if(cash == 0)
            {
                Console.Write("Enter Bet Amount:");
                cash = Convert.ToInt32(Console.ReadLine());
            }

            Random r1 = new Random();
            int c1 = r1.Next(1, 10);
            int c2 = r1.Next(1, 10);
            int c3 = r1.Next(1, 10);

            //int c1 = 3;
            //int c2 = 2;
            //int c3 = 1;

            Console.WriteLine($"Slot Machine: {c1} {c2} {c3}");
            if ((c1 == c2) && (c1 == c3))
            {
                cash = cash * 10;
                Console.WriteLine("Congratulations!! \nYou Hit Jackpot 10X CASH \nBalance: " + cash );
            }
            else if ((c1 == c2) || (c2 == c3))
            {
                cash = cash * 2;
                Console.WriteLine("Congratulations!! \nTwo Consecutive Numbers 2X CASH \nBalance: " + cash);
            }
            else if (((c3 == c2 + 1) && (c2 == c1 + 1)) || ((c1 == c2 + 1) && (c2 == c3 + 1)))
            {
                cash = cash * 3;
                Console.WriteLine("Congratulations!! \nConsecutive Numbers 3X CASH \nBalance: " + cash);
            }
            else
            {
                cash = 0;
                Console.WriteLine("Better Luck Next Time Chump \nBalance: " + cash);
            }
        }
        public void Spin()
        {
            int i = 1;

            Console.Write("Press Enter to Spin the Slot Machine ");
            while (Console.ReadLine() == "")
            {
                SpinOnce();

                if (i == 5)
                {
                    Console.WriteLine("You have reached the maximum number of spins");
                    break;
                }

                Console.Write("\n\nPress Enter to Spin Again ");
                i++;
            }
        }

    }
}
