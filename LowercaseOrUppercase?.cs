int lowercaseNumber, uppercaseNumber, result;

Console.Write("Enter the 1st character: ");
char a = Convert.ToChar(Console.ReadLine());

Console.Write("Enter the 2nd character: ");
char b = Convert.ToChar(Console.ReadLine());

Console.Write("Enter the 3rd character: ");
char c = Convert.ToChar(Console.ReadLine());

Console.Write("Enter the 4th character: ");
char d = Convert.ToChar(Console.ReadLine());

Console.Write("Enter the 5th character: ");
char e = Convert.ToChar(Console.ReadLine());

lowercaseNumber = 0;
uppercaseNumber = 0;

result = a >= 'A' && a <= 'Z' ? uppercaseNumber++ : lowercaseNumber++;
result = b >= 'A' && b <= 'Z' ? uppercaseNumber++ : lowercaseNumber++;
result = c >= 'A' && c <= 'Z' ? uppercaseNumber++ : lowercaseNumber++;
result = d >= 'A' && d <= 'Z' ? uppercaseNumber++ : lowercaseNumber++;
result = e >= 'A' && e <= 'Z' ? uppercaseNumber++ : lowercaseNumber++;

Console.WriteLine("You entered : " + lowercaseNumber + " lowercase number");
Console.WriteLine("You entered : " + uppercaseNumber + " uppercase number");
Console.WriteLine(uppercaseNumber>lowercaseNumber ? "You entered more uppercase number" : "You entered more lowercase number");

