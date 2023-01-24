float number,x0 ,x1,x2,control1,control2;

Console.Write("Enter the number : ");
number = float.Parse(Console.ReadLine());

while(number <0 || number > 100)
{
    Console.WriteLine("Number must be between 0 and 100!");
    Console.Write("Enter the number : ");
    number = int.Parse(Console.ReadLine());
}

Random rnd = new Random();
x0 = rnd.Next(0, 101);
x1 = (x0 + (number / x0)) / 2f;
Console.WriteLine(x1);

do
{
    
    x2 = (x1 + (number / x1)) / 2f;
    control1 = (x1 * 100) - ((x1 * 100) % 1f);
    control2 = (x2 * 100) - ((x2 * 100) % 1f);
    Console.WriteLine(x2);
    x1 =x2 ;

} while (control1 !=control2);
