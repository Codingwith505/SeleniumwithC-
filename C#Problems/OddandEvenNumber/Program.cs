

//


String[] str = { "2am", "1I", "3a", "4boy" };

String[] arrangedWord = new String[str.Length];


foreach (String s in str)
{
    int i = int.Parse(s.Substring(0, 1));

    Console.WriteLine(i);
    arrangedWord[i - 1] = s.Substring(1);
}

foreach (String str2 in arrangedWord)
{
    Console.Write(str2 + " ");
}

