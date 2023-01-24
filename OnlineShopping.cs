int password , takenPassword ;


double totalPrice;
totalPrice = 0;

string brandNameOrID , brandName1, brandName2, brandName3, brandName4, computerdID1 , computerdID2, computerdID3, computerdID4;

brandName1 = "Dell";
brandName2 = "Asus";
brandName3 = "Monster";
brandName4 = "HP";
computerdID1 = "234";
computerdID2 = "536";
computerdID3 = "862";
computerdID4 = "601";

char studentStatus;

Console.Write("Enter your password : ");
takenPassword = int.Parse(Console.ReadLine());

if(takenPassword<=999999 && takenPassword>999)
{
    Console.Write("Enter a brand name or a computer ID : ");
    brandNameOrID = Console.ReadLine();

    if(brandNameOrID == brandName1 || brandNameOrID == brandName2 || brandNameOrID == brandName3 || brandNameOrID == brandName4 || brandNameOrID == computerdID1 || brandNameOrID == computerdID2 || brandNameOrID == computerdID3 || brandNameOrID == computerdID4)
    {
        Console.Write("Are you a student ? (Y/N) :");
        studentStatus = char.Parse(Console.ReadLine());

        if(studentStatus == 'Y')
        {
            switch (brandNameOrID)
            {
                case "234":
                    totalPrice = 2500 - 2500 * (20 / 100d);
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Dell":
                    totalPrice = 2500 - (2500 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}" , totalPrice);
                    break;
                case "536":
                    totalPrice = 1500 - (1500 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Asus":
                    totalPrice = 1500 - (1500 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "862":
                    totalPrice = 1000 - (1000 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Monster":
                    totalPrice = 1000 - (1000 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "601":
                    totalPrice = 1750 - (1750 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "HP":
                    totalPrice = 1750 - (1750 * (20 / 100d));
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
            }
        }
        else if(studentStatus == 'N')
        {
            switch (brandNameOrID)
            {
                case "234":
                    totalPrice = 2500;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Dell":
                    totalPrice = 2500;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "536":
                    totalPrice = 1500;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Asus":
                    totalPrice = 1500;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "862":
                    totalPrice = 1000;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "Monster":
                    totalPrice = 1000;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "601":
                    totalPrice = 2500;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
                case "HP":
                    totalPrice = 1750;
                    Console.WriteLine("Total price is :{0:C}", totalPrice);
                    break;
            }

         }
    }else
    {
        Console.WriteLine("There is no matching brand name or ID according to your input");
    }


}else{
    Console.WriteLine("Password is incorrect ! ");
    }
    