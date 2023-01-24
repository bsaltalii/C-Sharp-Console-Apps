static long TakeCardNumber()
{
    Console.Write("Enter your credit card number : ");
    long cardNumber = long.Parse(Console.ReadLine());
    return cardNumber;
}

static bool CheckLength(long number)
{
    int counter = 0;

    while (number > 0)
    {
        number /= 10;
        counter++;
    }
    if (counter == 16)
        return true;
    else
        return false;
}

static int SumOfOdds(long number)
{
    int counter = 15;
    int sum = 0;
    int digit = 0;
    int[] numbersDigit = new int[16];

    while (number > 0)
    {
        digit = (int)(number % 10);
        numbersDigit[counter] = digit;
        number /= 10;
        counter--;
    }
    for (int i = 1; i < numbersDigit.Length; i += 2)
    {
        sum += numbersDigit[i];
    }
    return sum;
}

static int SumOfEvens(long number)
{
    int counter = 15;
    int sum = 0;
    int digit = 0;
    int secondDigit = 0;
    int doubleSum = 0;
    int secondSum = 0;
    int eventuallySum = 0;
    int[] numbersDigit = new int[16];

    while (number > 0)
    {
        digit = (int)(number % 10);
        numbersDigit[counter] = digit;
        number /= 10;
        counter--;
    }
    for (int i = 2; i < numbersDigit.Length; i += 2)
    {
        sum += numbersDigit[i];
    }

    doubleSum = sum * 2;

    while (doubleSum > 0 && doubleSum<100)
    {
        secondDigit = doubleSum % 10;
        secondSum += secondDigit;
        doubleSum /= 10;
    }
    while (secondSum > 0 && doubleSum<100)
    {
        secondDigit = secondSum % 10;
        eventuallySum += secondDigit;
        secondSum /= 10;
    }

    return eventuallySum;
}

static bool IsDivisible(int sumOfDigits,int sumOfOdds)
{
    if ((sumOfDigits+sumOfOdds)%10==0)
    {
        return true;
    }
    return false;
}

static string BelongsTo(long number)
{
    int counter = 15;
    int digit = 0;
    int[] numbersDigit = new int[16];

    while (number > 0)
    {
        digit = (int)(number % 10);
        numbersDigit[counter] = digit;
        number /= 10;
        counter--;
    }
    if (numbersDigit[0] == 4 && numbersDigit[1] == 2)
    {
        return "a MasterCard logo";
    }
    else if (numbersDigit[0] == 4 && numbersDigit[1] == 3)
    {
        return "a Visa logo";
    }
    else
    {
        return "no logo";
    }
}
