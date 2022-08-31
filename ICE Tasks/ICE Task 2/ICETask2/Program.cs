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

            for(int i = 1; i < numbers.Length; i++)
            {
                temp = numbers[i];
                int j = i--;

                while (j >= 0 && numbers[j] > numbers[i])
                {
                    numbers[i] = numbers[j];
                    j--;

                }
                numbers[i] = temp;                                        
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
            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Sorting Array
            mySort(nums);

            //Printing of sorted Array
            Console.WriteLine("Sorted Array");            
            foreach (int n in nums)
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }
    }
}

