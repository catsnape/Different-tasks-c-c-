using System;

public class MainClass
{
    public static void Main()
    {
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        int cChar = s.Length;
        for(int i=0;i<=cChar-1;i++)
        {
           {  
               if (i==k-1) 
                 continue;
           }
        Console.Write(s[i]);
        }
    }
}
