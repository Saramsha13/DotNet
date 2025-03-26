using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Marks
    {
        int[] allmark = new int[5];

        public void addMarks()
        {
            Console.WriteLine("Enter the marks of 5 subjects: ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"\nEnter the marks of {i+1} subject: ");
                allmark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void calculatePercentage()
        {
            int total = 0;
            for (int i = 0; i < allmark.Length; i++)
            {
                total += allmark[i];
            }
            double percentage = (total / 500.0) * 100;
            Console.WriteLine($"\nThe Total Marks of the student is {total}");
            Console.WriteLine($"\nThe percentage of the student is {percentage}%");
        }
    }
}
