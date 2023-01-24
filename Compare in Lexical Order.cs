Console.Write("Enter the first string : ");
string wordOne = Console.ReadLine();
char[] arrayOne = wordOne.ToCharArray();

Console.Write("Enter the first string : ");
string wordTwo = Console.ReadLine();
char[] arrayTwo = wordTwo.ToCharArray();

for( int i = 0; i < wordOne.Length; i++)
{
    if (arrayOne[i]< arrayTwo[i])
    {
        Console.WriteLine("First string comes before second string");
        break;
    }
    else if (arrayTwo[i] < arrayOne[i])
    {
        Console.WriteLine("Second string comes before first string");
        break;
    }

}