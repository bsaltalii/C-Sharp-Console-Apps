int temporaryVariable ,minValue ,maxValue ,medianValue,q1,q3,iqr;

temporaryVariable = 0;
minValue = 100;
maxValue = 0;
medianValue = 0;
q1 = 0;
iqr = 0;
q3 = 0;

int[] numbers = new int[15];

//CREATİNG ARRAY

Console.WriteLine("Randomly created array with length 15 is : ");

for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(-100, 100);
    Console.Write(" " + numbers[i]);
}
//END

//SORTİNG
Console.WriteLine(" ");
Console.WriteLine("\nSorted array with length 15 is : ");

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 1; j < numbers.Length; j++)
    {
        if (numbers[j - 1] > numbers[j])
        {
            temporaryVariable = numbers[j - 1];
            numbers[j - 1] = numbers[j];
            numbers[j] = temporaryVariable;
        }
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("{0} ", numbers[i]);
}
//END

//FINDING Q1
Console.WriteLine(" ");
q1 = numbers[((numbers.Length / 4))];

Console.WriteLine("\nQ1 of the array is : {0}", q1);
//END

//FINDING Q3
Console.WriteLine(" ");
q3 = numbers[((numbers.Length*3)/4)];

Console.WriteLine("\nQ3 of the array is : {0}" ,q3);

//END

//FINDING IQR
Console.WriteLine(" ");
iqr = q3 - q1;

Console.WriteLine("\nIQR of the array is : {0}", iqr);

//FINDING MIN VALUE
Console.WriteLine(" ");
minValue = numbers[0];

Console.WriteLine("\nMinimum of the array is : {0}", minValue);
//END

//FINDING MAX VALUE
Console.WriteLine(" ");
maxValue = numbers[(numbers.Length - 1)];

Console.WriteLine("\nMaximum of the array is : {0}",maxValue);
//END

//FINDING MEDIAN VALUE
Console.WriteLine(" ");
medianValue = numbers[(numbers.Length / 2)];

Console.WriteLine("\nMedian value of the array is : {0}", medianValue);
//END