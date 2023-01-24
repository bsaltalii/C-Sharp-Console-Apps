Console.WriteLine("Enter tempereture value :");
int tempereture = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter wind value :");
int wind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter humidity value :");
int humidity = Convert.ToInt32(Console.ReadLine());

int possibility = ((tempereture - wind) * (tempereture - wind)) - humidity;

Console.WriteLine(possibility > 575 ? "The result is {0} and there will not be rain." : "The result is {0} and there will be rain. " ,possibility);