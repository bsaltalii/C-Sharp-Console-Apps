Console.WriteLine("Matrix a : ");
int[,] matrixA =
{
    {1,4,2},
    {2,5,1},
    {3,8,2}
};
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int k = 0; k < matrixA.GetLength(1); k++)
    {
        Console.Write("{0}\t", matrixA[i, k]);
    }
    Console.WriteLine("\n");
}

Console.WriteLine("Matrix b : ");
int[,] matrixB=
{
    {3,4,2},
    {3,5,7},
    {1,2,1}
};

for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int k = 0; k < matrixB.GetLength(1); k++)
    {
        Console.Write("{0}\t", matrixB[i, k]);
    }
    Console.WriteLine("\n");
}

int[,] productMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
int element = 0;

Console.WriteLine("Product of matrices : ");
Console.WriteLine();
for(int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++) {

        element = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {           
            element += matrixA[i, k] * matrixB[k, j];        
        }
        productMatrix[i, j] = element;
    }
}
for(int i = 0; i < productMatrix.GetLength(0); i++)
{
    for(int k=0; k < productMatrix.GetLength(1); k++)
    {
        Console.Write("{0}\t", productMatrix[i, k]);
    }
    Console.WriteLine("\n");
}