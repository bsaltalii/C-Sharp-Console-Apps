int resultOfMultiply, resultOfSum, number, counter,digit;

counter = 0;
resultOfSum = 0;
resultOfMultiply = 1;

Console.Write("Enter a number : ");
number = int.Parse(Console.ReadLine());

for(int i =1; i<=number; i *= 10)
{
    
    digit = (number / i) % 10;
    counter++;

    if(counter % 2 == 1)
    {                
            resultOfMultiply *= digit;
    }
    else
    {        
            resultOfSum += digit;        
    }
}
Console.WriteLine("Product of odd number is : {0}",resultOfMultiply);
Console.WriteLine("Sum of even number is : {0}", resultOfSum);