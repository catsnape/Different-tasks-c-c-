using System;

public class MainClass
{
    public static void Main()
    {
       string s = Console.ReadLine();
        string n="";
        for(int i =s.Length-1;i>=0;i--)
        {    
            n = n+s[i];
        }  
        if(s==n) Console.Write("YES");
        else Console.WriteLine("NO");
    }
}
