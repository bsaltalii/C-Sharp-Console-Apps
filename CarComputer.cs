float literPerKilometer, kilometer, literOfGas, totalCost;

literPerKilometer = (3 / 7f);
Console.WriteLine("liter per kilometer is : " + literPerKilometer + " liters");

kilometer = (14600 / 1000f);
Console.WriteLine("Destination in kilometer is : " + kilometer + " kilometers");

literOfGas = 4.15f;
Console.WriteLine("Liter of gas is : " + literOfGas + "$");

totalCost = (literPerKilometer * kilometer * literOfGas);
Console.WriteLine("Total cost is : " + totalCost + "$");
