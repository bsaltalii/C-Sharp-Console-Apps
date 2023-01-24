//HOCAM ÖDEVDE DEĞERLERİ İNTEGER OLARAK ALIN DİYOR AMA
//BÖLME İŞLEMİNDE DAHA DOĞRU CEVAP ALABİLMEK İÇİN (SONUCUN SIFIR ÇIKMASI GİBİ)
//RESULT DEĞERİNİ DOUBLE VERİ TÜRÜNE ÇEVİRDİM.


int firstİnteger, secondİnteger, operationType ;

double result;

string outputMessage = "Result of the operation is : ";

result = 0;

Console.WriteLine("1-Addition");
Console.WriteLine("2-Substraction");
Console.WriteLine("3-Multiplication");
Console.WriteLine("4-Division");

Console.Write("Select an operation : ");
operationType = int.Parse(Console.ReadLine());

Console.Write("Enter first integer : ");
firstİnteger = int.Parse(Console.ReadLine());

Console.Write("Enter second integer : ");
secondİnteger = int.Parse(Console.ReadLine());


switch (operationType)
{
    case 1:
        result = (double)firstİnteger + secondİnteger;
        Console.WriteLine(outputMessage + "{0:F2}", result);
        break;

    case 2:

        if (secondİnteger > firstİnteger)

        {
            Console.WriteLine("You must enter bigger integer value for first integer !");
            break;                

        }else {
            result = (double)firstİnteger - secondİnteger;
            Console.WriteLine(outputMessage + "{0:F2}", result);
        }
            break;

    case 3:
        result = (double)firstİnteger * secondİnteger;
        Console.WriteLine(outputMessage + "{0:F2}", result);
        break;

    case 4:

        if(secondİnteger == 0)
        {
            Console.WriteLine("Error ! The divisor number can not be zero");
            break;
        }
        else {
            result = (double)firstİnteger / secondİnteger;
            Console.WriteLine(outputMessage +  "{0:F2}", result);
            break;
        }


       
}
