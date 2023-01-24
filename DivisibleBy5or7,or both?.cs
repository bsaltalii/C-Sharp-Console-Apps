Console.Write("Enter the number : ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Error ! Number is smaller than 0.");
}
else if (number > 500)
{
    Console.WriteLine("Error ! Number is bigger than 500.");
}
else if (number % 5 == 0)
{
    Console.WriteLine("Number {0} is divisible by 5", number);
}
else if (number % 7 == 0)
{
    Console.WriteLine("Number {0} is divisible by 7", number);
}
else if (number % 35 == 0)
{
    Console.WriteLine("Number {0} is divisible by both 5 and 7", number);
}
else if (number % 35 != 0)
{
    Console.WriteLine("Number {0} is not divisible by both 5 and 7", number);
}
else;