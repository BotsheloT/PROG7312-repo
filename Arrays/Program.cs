using System;
using System.Collections;
using System.Collections.Generic;

//Array for 10 numbers
int[] nums = new int[10];

//List for 10 numbers
List<int> numbers = new List<int>();

//Variable for random numbers
Random ran = new Random();

/*foreach (int num in nums)
{
    Random ran = new Random();
    num = ran.Next(0, 100);
}
Foreach only works for objects that that already have an assigned value*/

for (int i = 0; i < 10; i++)
{    
    nums[i] = ran.Next(1, 100);
    numbers.Add(ran.Next(1, 100));
}

numbers.Sort();

//Sorted list for testing
/*This functions as a key value pair collection*/
SortedList<int, int> kvpNums = new SortedList<int, int>();

/*Ensure that you follow the data types that are Assoctiated with the key and 
*its value. Keys cannot be repeated either*/
kvpNums.Add(6, 14);
kvpNums.Add(2, 81);
kvpNums.Add(3, 7);
kvpNums.Add(4, 10);
kvpNums.Add(5, 65);

//Displaying the values
foreach (KeyValuePair<int, int> item in kvpNums)
{
    Console.WriteLine(item);
}

//Displaying the values in the KVP only
foreach (int val in kvpNums.Values)
{
    Console.WriteLine(val);
}