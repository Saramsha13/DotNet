using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Arrays
    {
        string[] students = {"Harry", "Simon", "Brian", "Adams"};
        string[] students1 = new string[5];

        int[] numbers = { 5, 8, 7, 4, 3 };

        public void addStudents()
        {
            students1[0] = "Dharmindar";
            students1[1] = "Gudhmindar";
            students1[2] = "Tullu";
        }

        public void displayOne(int n)
        {
            Console.WriteLine("Student " + n + " is "+ students[n+1]);
        }
        
        public void showStudents()
        {
            //To display the first student
            Console.WriteLine($"Student 1 is {students[0]}");

            Console.WriteLine();

            //To display the students through a loop
            for (int i = 0; i < students.Length; i++) {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine();

            //To display the students using foreach loop
            foreach (string student in students1)
            {
                Console.WriteLine(student);
            }
        }
    }
}
