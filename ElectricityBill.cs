double electricityBill , totalUnits ,totalElectricityBill;

Console.Write("Enter total units consumed : ");
totalUnits = double.Parse(Console.ReadLine());

if(totalUnits <= 50)
{
    electricityBill = (totalUnits * 0.5d);
    
}
else if(totalUnits <= 150)
{
    electricityBill = (50 * 0.5) + (totalUnits - 50 * 0.75d);
 
}
else if(totalUnits <= 250)
{
    electricityBill = (50 * 0.5d) + (100 * 0.75d) + ((totalUnits - 150) * 1.2d);

}
else
{
    electricityBill = (50 * 0.5d) + (100 * 0.75d) + (100 * 1.2d) + ((totalUnits - 250) * 1.5);

};

totalElectricityBill = electricityBill + electricityBill * (20 / 100d);
Console.WriteLine("Net electricity bill is : {0:C}", totalElectricityBill);