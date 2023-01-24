int biggerTotalTime = 0;

string[] roadOne = { "Green", "Yellow", "Red" };
string[] roadTwo = { "Red", "Green", "Yellow" };

int[] roadOneLights = { 35, 10, 20 };
int[] roadTwoLights = { 10, 20, 35 };

int totalTimeRoadOne = roadOneLights[0];
int totalTimeRoadTwo = roadTwoLights[0];

for (int i = 0; i < roadOneLights.Length; i++)
{
    biggerTotalTime += roadOneLights[i];
}

int one = 0;
int two = 0;

for (int j = 0; j < biggerTotalTime; j++)
{
    if (j < totalTimeRoadOne)
    {
        Console.Write("\nState of lamb1 : {0}", roadOne[one]);       
    }else
    {
        one++;
        totalTimeRoadOne += roadOneLights[one];
        Console.Write("\nState of lamb1 : {0}", roadOne[one]);
    }
    if (j < totalTimeRoadTwo)
    {
        Console.Write("\t ,lamb2 : {0} at the time {1}", roadTwo[two], (j+1));
        Console.WriteLine();
    }
    else
    {
        two++;
        totalTimeRoadTwo += roadTwoLights[two];
        Console.Write("\t ,lamb2 : {0} at the time {1}", roadTwo[two],(j+1));
        Console.WriteLine();
    }

    if (roadOne[one] == "Green" && roadTwo[two] == "Green")
    {
        Console.WriteLine("\nThere might be a accient at the time {0}", (j + 1));

    }else if(roadOne[one] == "Green" && roadTwo[two] == "Yellow"|| roadOne[one] == "Yellow" && roadTwo[two] == "Green")
    {
        Console.WriteLine("\nThere might be a accient at the time {0}", (j + 1));
    }else if(roadOne[one] == "Yellow" && roadTwo[two] == "Yellow")
    {
        Console.WriteLine("\nThere might be a accient at the time {0}", (j + 1));
    }

}

