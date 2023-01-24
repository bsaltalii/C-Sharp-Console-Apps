using System.Diagnostics.Metrics;
using System.Text;

static int MaximumFrequency(string str)
{
    int[] frequency = new int[str.Length];
    int counter = 0;
    int max = 0;
    int index = 0;

    for (int i = 0; i < str.Length; i++)
    {
        counter = 0;
        index = str.IndexOf(str[i]);

        while (index != -1)
        {
            counter++;
            index = str.IndexOf(str[i],index+1);
        }
        frequency[i] = counter;
    }
    for (int i = 0; i < frequency.Length; i++)
    {
        if (frequency[i]>max)
        {
            max = frequency[i];
        }        
    }
    return max;
}

static string SortCharacters(string str)
{

    string[] elementsOfStr = str.Split(" ");
    string temp = "";

    StringBuilder builder = new StringBuilder();

    for (int i = 0; i < elementsOfStr.Length; i++)
    {
        for (int j = 1; j < elementsOfStr.Length; j++)
        {
            if (string.Compare(elementsOfStr[j - 1] , elementsOfStr[j])==1)
            {
                temp = elementsOfStr[j - 1];
                elementsOfStr[j - 1] = elementsOfStr[j];
                elementsOfStr[j] = temp;
            }
        }
        builder.Append(elementsOfStr[i]);
        builder.Append(" ");
    }
    return builder.ToString();
}

static string ReverseStringsInOddLength(string str)
{
    string[] newString = str.Split(" ");
    StringBuilder builder = new StringBuilder();
    string reverseWord = "";

    for (int i = 0; i < newString.Length; i++)
    {
        if (newString[i].Length%2!=0)
        {
            reverseWord = newString[i];

            for (int j = (reverseWord.Length-1); j >=0; j--)
            {
                builder.Append(reverseWord[j]);
            }
            builder.Append(" ");
        }
        else
        {
            builder.Append(newString[i]);
            builder.Append(" ");
        }
    }
    return builder.ToString();
}

static string RemoveDuplicates(string str)
{
    string temp = "";
    string result = "";

    for(int i = str.Length - 1; i >= 0; i--)
    {
        if (temp.IndexOf(str[i]) == -1)

            temp += str[i];
    }
    for (int i = temp.Length-1; i >= 0; i--)
    {
        result += temp[i];
    }
    return result;
}

static bool IsIsogram(string str)
{
    int counter = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                counter++;
            }
        }
    }
    if (counter != str.Length)
        return false;
    else
        return true;
}

static bool IsIsogramBySecondDegree(string str)
{
    int counter = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                counter++;
            }
        }
    }
    if (counter != 2*str.Length)
        return false;
    else
        return true;
}
