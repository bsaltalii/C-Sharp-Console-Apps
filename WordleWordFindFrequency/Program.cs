using System.IO;
StreamReader reader = new StreamReader("wordlewords.txt");
StreamWriter writer = new StreamWriter("wordlenewwords.txt");

//CREATİNG CHAR ARRAYS
char[] characters = new char[26];
int counter = 0;

for (char i = 'A' ; i <= 'Z' ; i++)
{
    characters[counter]= i;
    counter++;
}
//END

//READİNG FİLE AND TRİM
using (reader)
{
    string line;

    using (writer)
    {
        while ((line = reader.ReadLine()) != null)
        {
            writer.WriteLine(line.Trim('\"', ' ', ','));
        }
    }
}
//END

//CREATİNG FREQUENCY ARRAY
double[] frequency = new double[26];

using (StreamReader sr = new StreamReader("wordlenewwords.txt"))
{
    string line;

    while ((line=sr.ReadLine()) != null)
    {
        for (int i = 0; i < line.Length; i++)
        {
            for (int j = 0; j < characters.Length; j++)
            {
                if (line[i] == characters[j])
                {
                    frequency[j]++;
                }
            }
        }
    }
}
//END

//CALCULATİNG TOTAL FREQUENCY
double totalUsageOfChar = 0;

for (int i = 0; i < frequency.Length; i++)
{
    totalUsageOfChar += frequency[i];
}
for (int i = 0; i < frequency.Length; i++)
{
    frequency[i] = (frequency[i]/totalUsageOfChar)*100d;
}
//END

//WRITING STATS
using(StreamWriter sw = new StreamWriter("../FinalWork.txt"))
{
    sw.WriteLine("Characters \t Frequency");
    for (int i = 0; i < frequency.Length; i++)
    {
        sw.WriteLine(characters[i] + " \t\t " + frequency[i]);
    }
}
//END
