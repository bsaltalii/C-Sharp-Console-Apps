int numberOfStudents, grade, highestScore, lowestScore;

highestScore = 0;
lowestScore = 100;

string name , highestScoreName, lowestScoreName;

numberOfStudents = 1;
highestScoreName = "";
lowestScoreName = "";


while (numberOfStudents <= 7)
{
    Console.Write("Enter the student's name : ");
    name = Console.ReadLine();
   
    Console.Write("Enter the student's grade : ");
    grade = int.Parse(Console.ReadLine());

    while(grade<0 || grade > 100)
    {
        Console.WriteLine("Grade must be between 0 and 100!");
        Console.Write("Enter the student's grade : ");
        grade = int.Parse(Console.ReadLine());
    }

    if (grade > highestScore)
    {
        highestScore = grade;
        highestScoreName = name;
    }
    if (grade < lowestScore)
    {
        lowestScore = grade;
        lowestScoreName = name;
    }
    numberOfStudents++;

}
Console.WriteLine("Highest grade belongs to {0}", highestScoreName);
Console.WriteLine("Lowest grade belongs to {0}", lowestScoreName);