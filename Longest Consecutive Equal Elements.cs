int lengthOfArray,counterOne,counterTwo,number;
counterOne = 1;
counterTwo = 1;
number = 0;

Console.Write("Enter the length of the array : ");
lengthOfArray = int.Parse(Console.ReadLine());

int[] array = new int[lengthOfArray];

for(int i = 0; i<lengthOfArray; i++)
{
    Console.Write("Enter the integer : ");
    array[i] = int.Parse(Console.ReadLine());

}
for(int j = 0; j < array.Length - 1; j++)
{
    if (array[j] == array[j + 1])
    {
        counterOne++;
    }
    else
    {
        counterOne = 1;
    }
    if (counterOne > counterTwo)
    {
        counterTwo = counterOne;
        number = array[j];
    }
}

Console.Write("Maximal sequence of consecutive equal elements { ");

for(int i = 0; i < counterTwo; i++)
{
    Console.Write(" {0} ", number);
    if (i == (counterTwo - 1))
    {
        continue;
    }
    else
    {
        Console.Write(",");
    }
}
Console.Write("}");