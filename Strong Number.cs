int total, product, counter ,number,digit;

total = 0;

Console.Write("Enter a number to check whether it is Strong number : ");
number = int.Parse(Console.ReadLine());

for(int i = 1; i <= number; i*=10)
{
    product = 1;
    digit = (number / i) % 10;
       
        for(int n = 1; n <= digit; n++)
        {
            product *= n;
        }                     

    total += product;
}
if(total == number)
{
    Console.WriteLine("{0} is a strong number" , number);
}
else
{
    Console.WriteLine("{0} is not a strong number", number);
}
