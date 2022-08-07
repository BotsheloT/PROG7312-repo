//Array for input data
int[] nums = new int[3];

//Variable for sum of even numbers
int sum = 0;


//For loop for user input
for (int i = 0; i < 3; i++)
{
    try
    {
        Console.WriteLine("Please enter a number");
        nums[i] = int.Parse(Console.ReadLine());
    }

    catch (NullReferenceException)
    {
        throw;
    }

    catch (TypeAccessException ex)
    {
        throw;
    }

    finally
    {
        //Check for even number
        if (nums[i] % 2 == 0)
        {
            sum += nums[i];
        }
    }
}

//Final results
Console.WriteLine("Sum of all even numbers stored in the array is: {0}", sum);


