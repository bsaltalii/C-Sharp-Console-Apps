int lengthOfArray ,temporarySum , realSum,counter;

temporarySum = 0;
realSum = 0;

Console.Write("Enter the length of array : ");
lengthOfArray = int.Parse(Console.ReadLine());

int[] array = new int[lengthOfArray];

for(int i = 0; i<array.Length; i++)
{
    Console.Write("Enter the value : ");
    array[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i<array.Length; i++)
{
    temporarySum = 0;

    for (int k = i; k < array.Length; k++)
    {
        
        temporarySum += array[k];        

        if (temporarySum > realSum)
        {
            realSum = temporarySum;
            
        }
    }
}
Console.WriteLine("Maximum sum : {0}" ,realSum);

