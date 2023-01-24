int sum = 0;
int[,] matrix =
{
    {2,7,3,2,1},
    {1,2,2,6,1},
    {4,2,9,3,1},
    {2,5,1,3,6},
    {3,6,9,2,1}
};

Console.WriteLine("Matrix a : ");
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write("{0} ", matrix[i, j]);
    }
    Console.WriteLine();
}

for(int i =0; i < matrix.GetLength(0); i++)
{
    for (int j = i; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
}
Console.WriteLine("\nSum of the upper triangle : " + sum);
Console.ReadLine();
