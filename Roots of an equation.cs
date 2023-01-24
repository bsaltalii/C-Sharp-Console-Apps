double a, b, c,delta ,root1,root2;
int firstRoot, secondRoot ,counter;

a = 2;  b = 4; c = -6; counter = 1;

delta = (b * b) - (4 * a * c);
delta = Math.Sqrt(delta);
root1 = (-b + delta) / (2 * a); root2 = (-b - delta) / (2 * a);

do
{
    Random rnd = new Random();
    firstRoot = rnd.Next(0, 10);

    Random rnd2 = new Random();
    secondRoot = rnd.Next(-9, 1);

    Console.WriteLine("{0}. iteration - Root1: {1} Root2: {2}", counter, firstRoot, secondRoot);

    counter++;


} while (firstRoot != root1 || secondRoot!=root2);