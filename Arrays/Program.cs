//Array for 10 numbers
int[] nums = new int[10];

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
    nums[i] = ran.Next(0, 100);
}

