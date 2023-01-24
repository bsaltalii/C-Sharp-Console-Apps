int greatestItem = 0;
int counter = 0;
int secondGreatestItem = 0;
int[] numbers = new int[15];

Console.WriteLine("Newly created list is : ");
for (int i = 0; i < 15; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(0, 50);
    Console.Write(" " + numbers[i]);
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > greatestItem)
    {
        secondGreatestItem = greatestItem;
        greatestItem = numbers[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine("\nGreatest item : " + greatestItem);

for(int i=0; i<numbers.Length;i++)
{
    if (numbers[i] < greatestItem)
    {
        secondGreatestItem = numbers[i];

        for(int j=0; j < numbers.Length; j++)
        {
            if (numbers[j] > secondGreatestItem && numbers[j] < greatestItem)
            {
                secondGreatestItem = numbers[j];
            }
        }
    }
}
foreach(int j in numbers)
{
    if (j == greatestItem)
    {
        counter++;
        if (counter >= 2)
        {
            secondGreatestItem = greatestItem;
        }
    }
}

Console.WriteLine("\nSecond greatest item : " + secondGreatestItem);



