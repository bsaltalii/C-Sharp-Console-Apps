static int GetPositiveNumber()
{
    Console.Write("Enter a positive number : ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        return number;
    }
    else
    {
        while (number < 0)
        {
            Console.Write("Enter a positive number : ");
            number = int.Parse(Console.ReadLine());
        }
        return number;
    }
}

static void printMersenneNumber(int number)
{
    double mersenneNumber = 0;

    for (int i = 1; i < Math.Sqrt(number)+1; i++)
    {
        mersenneNumber = (Math.Pow(2, i) - 1);

        for (double j = 0; j < number; j++)
        {
            if (j == mersenneNumber)
            {
                Console.WriteLine(j);
            }
        }
    }
}

static void printPrimeMersenneNumbers(int number)
{
    double mersenneNumber = 0;
    int counter = 0;

    for (int i = 1; i < Math.Sqrt(number) + 1; i++)
    {
        mersenneNumber = (Math.Pow(2, i) - 1);
        
        for (double j = 0; j < number; j++)
        {

            if (j == mersenneNumber)
            {
                counter = 0;
                for (int k = 1; k <= mersenneNumber; k++)
                {
                    if (mersenneNumber % k == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine(mersenneNumber);
                }
            }
        }
    }
}
