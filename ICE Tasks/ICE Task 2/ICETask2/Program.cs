using System;

namespace ICETask2
{
    class Program
    {
        //Method to sort an array
        public static void mySort(int[] numbers)
        {
            //Temp value for sorting
            int temp;

            for(int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    //Sorting exchange between larger and smaller number
                    if (numbers[i] > numbers[j])
                    {
                        temp = j;
                        numbers[j] = i;
                        numbers[i] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Array to be sorted
            int[] nums = new int[10];

            //Random object to generate random number in array
            Random ran = new Random();

            //Assignemt of array values
            for (int k = 0; k < 10; k++)
            {
                nums[k] = ran.Next(1, 21);
            }

            //Printing of unsorted array
            Console.WriteLine("Unsorted Array");
            Console.WriteLine("*****************************");
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            //Sorting Array

            //Printing of sorted Array
            Console.WriteLine("\nSorted Array");
            Console.WriteLine("*****************************");
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}

