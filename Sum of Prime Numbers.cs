int counter, prime, sum,number ;

prime = 2;
sum = 0;


Console.Write("Enter value n : ");
number = int.Parse(Console.ReadLine());

while(number <= 1)
{
    Console.WriteLine("Number must be at least 2");
    Console.Write("Enter value n : ");
    number = int.Parse(Console.ReadLine());
}

while (prime<=number)
{

  counter = 0;

    for (int i = 1; i <= prime; i++)
      {
        if(prime % i == 0)
          {
            counter++;            
          }
      } 

    if (counter == 2)
    {
        Console.WriteLine(prime);
        sum += prime;
    }
    prime++;
}

Console.WriteLine("Sum of the prime is : " + sum);
