static string ConvertToLowercase(string str)
{
    int difference = 32;
    string word = "";

    for (int i = 0; i < str.Length; i++)
    {
        char letter = str[i];

        if (str[i] <= 97)
        {
            letter = (char)(difference + letter);
        }
        word+=letter;
    }
    return word;
}

static string ConvertToUppercase(string str)
{
    int difference = 32;
    string word = "";

    for (int i = 0; i < str.Length; i++)
    {
        char letter = str[i];

        if (str[i] >= 97)
        {
            letter = (char)(letter-difference);
        }
        word += letter;
    }
    return word;
}

static bool IsEqual(string str1,string str2)
{

    if (str1.Length == str2.Length)
    {
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }
    }        
    else
    {
        return false;
    }
    return true;
}

static char SecondMostFrequentLetter(string str)
{
    int[] frequency = new int[str.Length];
    int max = 0;
    int secondMax = 0;
    char secondMostFrequentLetter = 'a';

    for (int i = 0; i < str.Length; i++)
    {
        for (int k = 0; k < str.Length; k++)
        {
            if (str[i] == str[k])
            {
                frequency[i]++;
            }
        }
    }
    for (int i = 0; i < frequency.Length; i++)
    {
        if (frequency[i] > max)
        {
            max = frequency[i];
        }  
    }
    for (int i = 0; i < frequency.Length; i++)
    {
        for (int k = 0; k < frequency.Length; k++)
        {
            if (frequency[k] < max && frequency[k] > frequency[i])
            {
                secondMax = frequency[k];
            }
        }
    }
    for (int i = 0; i < frequency.Length; i++)
    {
        if (secondMax == frequency[i])
        {
            secondMostFrequentLetter = str[i];
        }
    }

    return secondMostFrequentLetter;
}

static bool IsContain(string str1,string str2)
{
    int counter = 0;

    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] == str2[0])
        {
            counter = 0;

            if ((i+str2.Length)<=str1.Length)
            {
                for (int k = 0; k < str2.Length; k++)
                {
                    if (str1[i + k] == str2[k])
                    {
                        counter++;

                        if (counter == str2.Length)
                        {
                            return true;
                        }
                    }
                }
            }
        }
    }
    return false;
}