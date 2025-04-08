using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inputs
    {
        public void takeInput()
        {
            Console.WriteLine("Enter Your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("Happy Birthday you turned " + i);
            }

            if (age > 16)
            {
                Console.WriteLine(name + " is older than 16");

            }
            else
            {
                Console.WriteLine(name + " is younger than 16");

            }
        }
    }
}
