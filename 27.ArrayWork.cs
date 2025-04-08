using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class ArrayWork
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
        int sum = 0, min = 0, max = 0;

        public void calcSum()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The Sum of the Elements of Array is: " + sum);
        }
        public void calcMinMax()
        {
            min = arr[0];
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Min: " + min + " Max: " + max);
        }
    }
}
