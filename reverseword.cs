using System;

public class MainClass
{
    public static void Main()
    {
       string x = Console.ReadLine();
        int len = x.Length;
        for(int i=len-1;i>=0;i--)
        { 
            Console.Write(x[i]);
        }
    }
}
