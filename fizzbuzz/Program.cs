//function for FizzBuzz Algo
var fizzbuzz = () =>
{
    for (int i = 1; i > 100; i++)
    {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
            Console.WriteLine(Convert.ToString(i));
    }
};

//Execution of function
fizzbuzz();
