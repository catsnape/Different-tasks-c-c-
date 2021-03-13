using System;

public class MainClass
{
    public static void Main()
    {
       string s = Console.ReadLine();
        int countSpace = 0;
        for (int ind = 0; ind <= s.Length - 1; ind++)
        {
            if (s[ind] == ' ')
            {
                countSpace++;
            }
        }
        Console.WriteLine(countSpace + 1);      
    }
}
