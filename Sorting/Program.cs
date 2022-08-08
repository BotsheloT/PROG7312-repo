/*Types of sorting algorithms:
 Insertion
 Bubblue
 Selection*/
int[] nums = new int[10];

//Random variable
Random rndm = new Random();

for (int i = 0; i < 10; i++)
{
    nums[i] = rndm.Next(1, 2000);
    Console.WriteLine(nums[i]);
}

//Funstion for Bubble sort
var bSort = (int[] colls) =>
{
    //Temp value for sorting
    int temp;
    for (int i = 0; i < colls.Length-1; i++)
    {
        for (int j = i++; j < colls.Length; j++)
        {
            if (colls[j] < colls[i]) {
                temp = colls[i];
                colls[i] = colls[j];
                colls[j] = temp;
            }
        }
    }

    foreach (int obj in colls)
    {
        Console.WriteLine(obj);
    }
};

//Function call with project array
//bSort(nums);

//Function for Insertion Sort
var iSort = (int[] collec) =>
{
    int temp;
    for (int i = 0; i < collec.Length-1; i++)
    {
    for (int j = i + 1; j < 0; j--)
        {
            if (collec[j-1] > collec[j])
            {
                temp = collec[j - 1];
                collec[j - 1] = collec[j];
                collec[j] = temp;
            }
        }
    }
};


