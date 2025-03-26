using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class Dick
    {
        Dictionary<string, string> studentDictionary = new Dictionary<string, string>();

        public void addStudents()
        {
            studentDictionary["Name"] = "Harry";
            studentDictionary.Add("Age", "28");
        }

        public void showStudents()
        {
            //To Display independently
            Console.WriteLine($"Name: {studentDictionary["Name"]}");
            Console.WriteLine($"Age: {studentDictionary["Age"]}");
            Console.WriteLine();

            //To Display the Values
            foreach (var student in studentDictionary.Values)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //To Display the Keys with the Values
            foreach (var student in studentDictionary.Keys)
            {
                Console.WriteLine(student+": " + studentDictionary[student]);
            }
            Console.WriteLine();

            //To Display the Keys with the Values
            foreach (var student in studentDictionary)
            {
                Console.WriteLine(student.Key + ":  " + student.Value);
            }
        }
    }
}
