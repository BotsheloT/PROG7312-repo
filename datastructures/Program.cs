//imports for array list
using System.Collections;

//Function for array lists
var usingArrayList = () =>
{
    ArrayList arrNumbers = new ArrayList();

    //Arraylist enteries
    arrNumbers.Add(2);
    arrNumbers.Add(4);
    arrNumbers.Add(6);
    arrNumbers.Add("Botshelo");

    //Final Print statement
    foreach (var item in arrNumbers)
    {
        Console.WriteLine(item);
    }
};

//Function for Queues
var usingQueues = () =>
{
    Queue p = new Queue();
};


var usingStacks = () =>
{   //Stack without type safety
    Stack st = new Stack();
    st.Push(6);
    st.Push(true);
    st.Push("Ryan");
    st.Push('p');



    //Stack with type safety
    Stack<int> stck = new Stack<int>();
    stck.Push(4);
    stck.Push(17);
    stck.Push(2);
    stck.Push(33);       
};

//Normal Array
int[] stuff = new int[2];

//2D Array
int[,] things = new int[2, 3];

//Initializing a 2D array
int[,] thangs = new int[2, 3] { {1, 2, 3}, {4, 5, 6} };

//Assigning values to empty array
things[0, 0] = 15;
things[0, 1] = 22;
things[0, 2] = 3;
things[1, 0] = 45;
things[1, 1] = 62;
things[1, 2] = 9;

string num = "16";

int.Parse(num);

usingArrayList();
