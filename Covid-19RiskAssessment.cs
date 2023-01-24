//HOCAM 0 PUAN VERECEĞİMİZ DURUMLAR İÇİN AYRI BİR CASE YAZMADIM.
//PUANI ETKİLEMEYECEĞİ İÇİN KOD KALABALIĞI OLUR DİYE DÜŞÜNDÜM.
//UMARIM DOĞRU DÜŞÜNMÜŞÜMDÜR.

int ageInterval , cov19Symptoms, cov19TestResults, cov19History ,totalScore = 0;

string outputMessage = "Total score of the assessment is : ";

Console.WriteLine("Select your age interval : ");
Console.WriteLine("1) 18-40");
Console.WriteLine("2) 40-65");
Console.WriteLine("3) 65+");
Console.Write("Your choice : ");
ageInterval = int.Parse(Console.ReadLine());

switch (ageInterval)
{
    case 1: totalScore += 5;
        break;
    case 2: totalScore += 15;
        break;
    case 3: totalScore += 25;
        break;
}

Console.WriteLine("Have experienced COV19 Symptoms ? ");
Console.WriteLine("1) Yes");
Console.WriteLine("2) No");
Console.Write("Your choice : ");
cov19Symptoms = int.Parse(Console.ReadLine());

switch (cov19Symptoms)
{
    case 1: totalScore += 25;
        break;
}

Console.WriteLine("What is your COV19 test result ? ");
Console.WriteLine("1) Positive");
Console.WriteLine("2) Negative");
Console.Write("Your choice : ");
cov19TestResults = int.Parse(Console.ReadLine());

switch (cov19TestResults)
{
    case 1: totalScore += 25;
        break;
}

Console.WriteLine("Have you ever been infected with COV19 before ? ");
Console.WriteLine("1) Yes");
Console.WriteLine("2) No");
Console.Write("Your choice : ");
cov19History = int.Parse(Console.ReadLine());

switch (cov19History)
{
    case 2: totalScore += 25;
        break;
}

if (totalScore < 25)
{
    Console.WriteLine(outputMessage + totalScore);
    Console.WriteLine("Patient should rest at home");

}else if(totalScore <50){

    Console.WriteLine(outputMessage + totalScore);
    Console.WriteLine("Patient can rest at home with medicine");  

}
else if (totalScore < 75) {

    Console.WriteLine(outputMessage + totalScore);
    Console.WriteLine("Patient should be controlled under the doctor");
    
}
else
{
    Console.WriteLine(outputMessage + totalScore);
    Console.WriteLine("Patient should be intubed immediately");  
}
