int temporaryVariable = 0;
int[] numbers = new int[15];

Console.WriteLine("Randomly created array with length 15 is : ");

for(int i = 0; i< numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(-100, 100);
    Console.Write(" " + numbers[i]);
}

Console.WriteLine(" ");
Console.WriteLine("\nSorted array with length 15 is : ");

for(int i = 0; i < numbers.Length; i++)
{
    for(int j = 1; j < numbers.Length; j++)
    {
        if (numbers[j-1] > numbers[j]) {
            temporaryVariable = numbers[j-1];
            numbers[j-1] = numbers[j];
            numbers[j] = temporaryVariable;            
        }
    }
}
for(int i = 0; i<numbers.Length; i++) {

    Console.Write("{0} ", numbers[i]);
}