using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7,14,52,6,49 };
            string[] arNames = new string[] { "Kabelo", "James", "Samantha", "Lesley", "Tebogo", "Nico" };

            Console.WriteLine("******** Numbers ********");
            bubbleSortArray(nums);

            Console.WriteLine("******** Names ********");
            bubbleSortArray(arNames);
            Console.Read();
        }

        //normal bubble sort method for an int value
        //private static void bubbleSortArray(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = (i + 1); j < nums.Length; j++)
        //        {
        //            if (nums[i] > nums[j])
        //            {
        //                int temp = nums[i];
        //                nums[i] = nums[j];
        //                nums[j] = temp;
        //            }
        //        }
        //    }
        //    foreach (int x in nums)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}

        //create a bubble sort method that will hold generics
        private static void bubbleSortArray<T>(T[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = (i + 1); j < ar.Length; j++)
                {
                    //Compare and CompareTo methods return 3 objects
                    if (Comparer<T>.Default.Compare(ar[i], ar[j]) == 1)
                    {
                        T temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            foreach (T x in ar)
            {
                Console.WriteLine(x);
            }
        }

    }
    
}
