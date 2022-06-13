string[] InputArray = CreateArray();

PrintArray(InputArray);
Console.WriteLine();

string[] ShorterThenFour = FindShorterThenFourStrings(InputArray);

PrintArray(ShorterThenFour);

string[] FindShorterThenFourStrings(string[] InputArray)
{
    string[] ShorterThenFour = new string[FindCountShortStrings(InputArray)];
    int count = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i].Length <= 3)
        {
        ShorterThenFour[count++] = InputArray[i];
        }
    }
    return ShorterThenFour;
}

int FindCountShortStrings(string[] InputArray)
{
    int count = 0;
    foreach (string s in InputArray)
    {
        if (s.Length <= 3)
            count++;
    }
    return count;
}



void PrintArray(string[] arr)
{
    foreach (string s in arr)
        Console.WriteLine(s);
}
string[] CreateArray()
{
    string[] InputArray = new string[int.Parse(Console.ReadLine())];
    for (int i = 0; i < InputArray.Length; i++)
    {
        InputArray[i] = "123";
        if (new Random().Next(0, 2) > 0)
        {
            InputArray[i] += "4" ;
        }
    }
    return InputArray;
}