
int[] groupOne = { 2, 5, 1, 2, 5, 3, 1, 2, 6, 1 };
int[] groupTwo = { 5, 4, 7, 6, 3, 9, 4, 5, 5, 6 };
int[] groupThree = { 9, 7, 6, 8, 4, 10, 8, 7, 9, 9 };

int[,] studentTable =
{
    {1,8,9,7,5,10,7,4,5,6,9},
    {2,4,5,6,4,6,5,3,2,1,7},
    {3,8,7,9,10,10,4,7,5,10,4},
    {4,1,4,6,3,2,0,2,3,5,6},
    {5,2,4,6,5,7,6,7,3,4,5}
};

double sum = 0;
double[,] studentsValuesTable = new double[3, studentTable.GetLength(0)];

for (int i = 0; i < studentTable.GetLength(0); i++)
{
    for (int j = 1; j < studentTable.GetLength(1); j++)
    {
        sum += Math.Pow((studentTable[i,j] - groupOne[j-1]), 2);
    }
    sum = Math.Sqrt(sum);
    studentsValuesTable[0, i] = sum;
}

for (int i = 0; i < studentTable.GetLength(0); i++)
{
    for (int j = 1; j < studentTable.GetLength(1); j++)
    {
        sum += Math.Pow((studentTable[i, j] - groupTwo[j-1]), 2);
    }
    sum = Math.Sqrt(sum);
    studentsValuesTable[1, i] = sum;
}

for (int i = 0; i < studentTable.GetLength(0); i++)
{
    for (int j = 1; j < studentTable.GetLength(1); j++)
    {
        sum += Math.Pow((studentTable[i, j] - groupThree[j-1]), 2);
    }
    sum = Math.Sqrt(sum);
    studentsValuesTable[2, i] = sum;
}

double groupNumber = 0;
double maxValue = 100;

for (int i = 0; i < studentsValuesTable.GetLength(1); i++)
{
    maxValue = 100;
    for (int j = 0; j < studentsValuesTable.GetLength(0); j++)
    {        
        if (studentsValuesTable[j,i] < maxValue)
        {
            maxValue = studentsValuesTable[j,i];
            groupNumber = j+1;
        }
    }
    Console.WriteLine("Student {0} belongs to group {1}" ,(i+1),groupNumber);
}
Console.ReadLine();
