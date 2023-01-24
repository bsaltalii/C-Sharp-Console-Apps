int smallestNumber, number1, number2, lcm, gcd;

lcm = 1;
gcd = 1;

Console.Write("Enter the first number : ");
number1 = int.Parse(Console.ReadLine());

while (number1 < 0)
{
    Console.WriteLine("Number must be greater than zero!");
    Console.Write("Enter the first number : ");
    number1 = int.Parse(Console.ReadLine());
}

Console.Write("Enter the second number : ");
number2 = int.Parse(Console.ReadLine());

while (number2 < 0)
{
    Console.WriteLine("Number must be greater than zero!");
    Console.Write("Enter the second number : ");
    number2 = int.Parse(Console.ReadLine());
}

if (number1 > number2)
{
    smallestNumber = number2;
}
else {
    smallestNumber = number1;
}
while (smallestNumber >= 1)
{
    if(number1 % smallestNumber ==0 && number2 % smallestNumber == 0)
    {
        gcd = smallestNumber;
        break;
    }
    smallestNumber--;
    
}
lcm = ((number1 / gcd) * (number2 / gcd))*gcd;
Console.WriteLine("LCM of {0} and {1} is : {2} ", number1,number2 ,lcm);
Console.WriteLine("GCD of {0} and {1} is : {2}", number1, number2,gcd);
