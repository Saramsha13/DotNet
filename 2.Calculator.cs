using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Calculator
    {
        public void calc()
        {

            Console.Write("Enter Num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose +, -, *, /");
            string op = Console.ReadLine();

            int result = 0;
            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;
            else
                Console.WriteLine("Enter a valid op");

            //switch (op)
            //{
            //    case "+":
            //        result = num1 + num2;
            //        break;
            //    case "-":
            //        result = num1 - num2;
            //        break;
            //    case "*":
            //        result = num1 * num2;
            //        break;
            //    case "/":
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Enter a valid op");
            //        break;
            //}

            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
        }
    }
}
