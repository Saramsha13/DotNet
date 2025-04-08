using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class DiceRoll
    {
        public void RollOnce()
        {
            Random r1 = new Random();
            int dice1 = r1.Next(1, 7);

            Console.Write("Guess the dice roll (1-6): ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            // Ensure valid integer input
            while (userGuess < 1 || userGuess > 6)
            {
                Console.Write("Invalid input! Enter a number between 1 and 6: ");
            }

            Console.WriteLine("Dice Rolled: " + dice1);

            if (userGuess == dice1)
            {
                Console.WriteLine("Congratulations! You guessed it right!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}
