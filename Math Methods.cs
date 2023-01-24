static int Min(int number1,int number2)
{
    if (number1>0 && number2>0)
    {
        if (number1 > number2)
        {
            return number2;

        }else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return number1;
        }
    }
    else
    {
        return -1;
    }
}

static int Max(int number1, int number2)
{
    if (number1 > 0 && number2 > 0)
    {
        if (number1 > number2)
        {
            return number1;

        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return number2;
        }
    }
    else
    {
        return -1;
    }
}

static int Pow(int number,int exponent)
{
    int pow = 1;

    if(number>0 && exponent > 0)
    {
        for (int i = 0; i < exponent; i++)
        {
            pow *= number;
        }
        return pow;
    }
    else
    {
        return -1;
    }
}

static  double Sqrt(double number1)
{
    double x0, x1, x2, control1, control2;

    if (number1 > 0)
    {
        Random rnd = new Random();
        x0 = rnd.Next(0, 101);
        x1 = (x0 + (number1 / x0)) / 2;

        do
        {

            x2 = (x1 + (number1 / x1)) / 2;
            control1 = (x1 * 100) - ((x1 * 100) % 1);
            control2 = (x2 * 100) - ((x2 * 100) % 1);
            x1 = x2;            

        } while (control1 != control2);
        return x2;
    }
    else
    {
        return -1;
    }
}

static void PrintsRootsOfEquation(int a,int b,int c)
{
    double delta = Pow(b,2) - (4 * a * c);
    if (delta < 0)
    {
        Console.WriteLine("Equation has not real roots");
    }
    else
    {
        int rootOne = (int)((-b + Sqrt(delta)) / (2 * a));
        Console.WriteLine("Root1 : " +rootOne);

        int rootTwo = (int)((-b -Sqrt(delta)) / (2 * a));
        Console.WriteLine("Root2 : " + rootTwo);
    }
}
