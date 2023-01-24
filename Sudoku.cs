int sumRow = 0;
int sumCol = 0;
int solutionControl = 0;
Random rnd = new Random();

int[,] sudoku =
{
    {2,8,3,7,9,5,4,1,6},
    {6,9,1,8,4,2,5,3,7},
    {4,7,5,6,3,1,2,9,8},
    {7,5,6,9,8,4,3,2,1},
    {1,3,9,5,2,6,7,8,4},
    {8,2,4,1,7,3,6,5,9},
    {9,4,2,3,6,8,1,7,5},
    {5,6,7,2,1,9,8,4,3},
    {3,1,8,4,5,7,9,6,2}
};
for (int i = 0; i < sudoku.GetLength(0); i++)
{
    for (int j = 0; j < sudoku.GetLength(1); j++)
    {        
        Console.Write("{0} ", sudoku[i, j]);
    }
    Console.WriteLine("");
}

for (int i = 0; i < sudoku.GetLength(0) ; i++)
{
    sumRow = 0;
    for (int j = 0; j < sudoku.GetLength(1); j++)
    {      
        sumRow += sudoku[i, j];
    }
    if (sumRow != 45)
    {
        Console.WriteLine("\nSum of row number {0} not 45!", i+1);
        solutionControl++;
    }
}

for (int i = 0; i < sudoku.GetLength(1); i++)
{
    sumCol = 0;
    for (int j = 0; j < sudoku.GetLength(0); j++)
    {
        sumCol += sudoku[j, i];
    }
    if (sumCol != 45)
    {
        Console.WriteLine("\nSum of column number {0} not 45!", i + 1);
        solutionControl++;
    }
}

int rowController = 0;
int row = 0;

for (int i = 0; i < sudoku.GetLength(0); i++)
{
    rowController = 0;
    for (int j = 1; j < sudoku.GetLength(1); j++)
    {
        for (int k = j; k < sudoku.GetLength(0); k++)
        {
            if (sudoku[i, j-1] == sudoku[i, k])
            {
                rowController++;
                row = i + 1;
            }
        }
    }
    if (rowController > 0)
    {
        Console.WriteLine("\nRow {0} does not contain numbers from 1 to 9!", row);
        solutionControl++;
    }
}

int colController = 0;
int col = 0;

for (int i = 0; i < sudoku.GetLength(1); i++)
{
    colController = 0;

    for (int j = 1; j < sudoku.GetLength(0); j++)
    {
        for (int k = j; k < sudoku.GetLength(1); k++)
        {
            if (sudoku[j-1,i] == sudoku[k,i])
            {
                colController++;
                col = i+1;
            }
        }
    }
    if (colController > 0)
    {
        Console.WriteLine("\nColumn {0} does not contain numbers from 1 to 9!", col);
        solutionControl++;
    }
}

int blockSum = 0;

for (int i = 0; i < sudoku.GetLength(0); i+=3)
{
    for (int j = 0; j < sudoku.GetLength(1); j+=3)
    {
        blockSum = 0;

        for (int k = j; k < j+3; k++)
        {
            for (int z = i; z < i+3; z++)
            {
                blockSum += sudoku[z, k];
            }
        }
        if (blockSum != 45)
        {
            Console.WriteLine("\nSum of the block that starts at [{0},{1}] indexes is not 45! ", i, j);
            solutionControl++;
        }
    }    
}

int[] indexController = new int[10];
int element = 0;

for (int i = 0; i < sudoku.GetLength(0); i += 3)
{
    for (int j = 0; j < sudoku.GetLength(1); j += 3)
    {
        for (int k = j; k < j + 3; k++)
        {
            for (int z = i; z < i + 3; z++)
            {
                element = sudoku[z, k];
                indexController[element]++;
            }                       
        }
        for (int t = 0; t < indexController.Length; t++)
        {
            if (indexController[t] > 1)
            {
                Console.WriteLine("\nBlock that starts at [{0},{1}] indexes is not contain numbers from 1 to 9! ", i, j);
                solutionControl++;
                indexController[t] = 0;
            }
            else
            {
                indexController[t] = 0;
            }
        }
    }
}

if (solutionControl > 0)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("\nSudoku solved correctly ! ");
}
Console.ReadLine();