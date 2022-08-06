//Array for input data
int[] nums = new int[3];

//For loop for user input
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please enter a number");
    nums[i] = int.Parse(Console.ReadLine());
}

//Variable for sum of even numbers
int sum = 0;

//Check for even numbers
foreach (int num in nums)
{
    if (num%2 == 0)
    {
        sum += num;
    }
}

//Final results
Console.WriteLine("Sum of all even numbers stored in the array is: {0}", sum);


