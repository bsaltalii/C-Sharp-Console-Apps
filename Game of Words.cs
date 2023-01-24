int a ,z ,check , lenghtOfSentence ,letter;

a = Convert.ToInt32('a');
z = Convert.ToInt32('z');
check = 0;
char converter = 'a';

Console.Write("Enter number of sentence : ");
lenghtOfSentence = int.Parse(Console.ReadLine());

Random rnd1 = new Random();
letter = rnd1.Next(a, z+1);

for(int i =0; i< lenghtOfSentence; i++)
{
    Random rnd = new Random();
    int lenghtOfWord = rnd.Next(3, 11);
    while(lenghtOfWord == check)
    {
       lenghtOfWord = rnd.Next(3, 11);
    }

    letter = rnd.Next(a, z + 1);
    converter = Convert.ToChar(letter);
    while(converter == 'a'|| converter == 'e' || converter == 'i' || converter == 'o' || converter == 'u')
    {
        letter = rnd.Next(a, z + 1);
        converter = Convert.ToChar(letter);
    }
        Console.Write(converter);
    
    for (int n = 2; n < lenghtOfWord; n++)
    {
        letter = rnd.Next(a, z + 1);
        converter = Convert.ToChar(letter);
        Console.Write(converter);
    }
    letter = rnd.Next(a, z + 1);
    converter = Convert.ToChar(letter);
    Console.WriteLine(converter);
    check = lenghtOfWord;
}
