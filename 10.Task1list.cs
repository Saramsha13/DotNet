using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Marks1
    {
        List<int> allmark = new List<int>();
        int n;
        public void addMarks()
        {
            Console.Write("Enter the number of subjects: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nEnter the marks of {i + 1} subject: ");
                allmark.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void calculatePercentage()
        {
            int total = 0;
            for (int i = 0; i < allmark.Count; i++)
            {
                total += allmark[i];
            }
            double percentage = (total / n);
            Console.WriteLine($"\nThe Total Marks of the student is {total}");
            Console.WriteLine($"\nThe Percentage of the student is {percentage}%");
        }
    }
}
