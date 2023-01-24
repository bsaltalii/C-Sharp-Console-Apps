int amount = 500;

Console.Write("Enter the amount for withdraw : ");
int withdraw = int.Parse(Console.ReadLine());

int remain = amount - withdraw;
Console.WriteLine(withdraw < amount ? "Amount in bank account: " + remain + "$" : remain > -500 ? "Amount in bank account: "+ remain + "$" + "\nYou are charged with : " + (-remain * 1.7) + "$" : "You can withdraw 1000$ at most! \n" + "You are charged with : " + ((-remain-amount)*1.7) + "$" + "\nAmount in bank account: " + (remain+amount)+"$");

