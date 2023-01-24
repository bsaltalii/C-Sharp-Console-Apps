Console.WriteLine("Enter x of Site 1 :");
int xOfSite1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y of Site 1 :");
int yOfSite1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x of Site 2 :");
int xOfSite2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x of Site 2 :");
int yOfSite2 = int.Parse(Console.ReadLine());

int distanceOfSite1 = (xOfSite1 - (-7)) * (xOfSite1 - (-7)) + (yOfSite1 - 5) * (yOfSite1 - 5);
Console.WriteLine("Distance from Site 1 to school : {0}" , distanceOfSite1);

int distanceOfSite2 = (xOfSite2 - (-7)) * (xOfSite2 - (-7)) + (yOfSite2 - 5) * (yOfSite2 - 5);
Console.WriteLine("Distance from Site 1 to school : {0}", distanceOfSite2);

Console.WriteLine(distanceOfSite1 < 120 ? "Construction site 1 is not allowed" : "Construction site 1 is allowed");
Console.WriteLine(distanceOfSite2 < 120 ? "Construction site 2 is not allowed" : "Construction site 2 is allowed");