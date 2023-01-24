static bool IsRotation(string str1,string str2)
{
    if (str1.Length!=str2.Length)
    {
        return false;
    }
    string str3 = str1 + " " + str1;
    int counter = 0;

    for (int i = 0; i < str3.Length; i++)
    {
        if (str3[i] == str2[0])
        {
            counter = 0;

            if ((i + str2.Length) <= str3.Length)
            {
                for (int k = 0; k < str2.Length; k++)
                {
                    if (str3[i + k] == str2[k])
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