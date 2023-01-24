int firstSide, secondSide, thirdSide, firstAngle, secondAngle, thirdAngle;

Console.WriteLine("Enter the first side : ");
firstSide = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second side : ");
secondSide = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third side : ");
thirdSide = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the first angle : ");
firstAngle = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second angle : ");
secondAngle = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third angle : ");
thirdAngle = int.Parse(Console.ReadLine());

if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
{
    Console.WriteLine("Sides are meeting the conditions.");
}
else
{
    Console.WriteLine("Sides are not meeting the conditions.");
}

if (firstAngle+secondAngle+thirdAngle == 180)
{
    Console.WriteLine("Angles are meeting the conditions.");
}else
{
    Console.WriteLine("Angles are not meeting the conditions.");
}

if(firstSide == secondSide || firstSide==thirdSide || secondSide == thirdSide)
{
    
    if (firstSide == secondSide && firstSide == thirdSide)
    {
        Console.WriteLine("Equilateral triangle");
    }
    else
    {
        Console.WriteLine("Isosceles triangle");
    }

}else
{
    Console.WriteLine("Scalene triangle");
}