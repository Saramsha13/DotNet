using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Lists
    {
        List<string> studentList = new List<string>();

        public void addStudents()
        {
            studentList.Add("Harry");
            studentList.Add("Simon");
            studentList.Add("Ethan");
        }

        public void showStudents()
        {
            //To display the students through a loop
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i]);
            }

            Console.WriteLine();

            //To display the students using foreach loop
            foreach (string student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
