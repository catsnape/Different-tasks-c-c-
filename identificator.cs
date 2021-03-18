using System;

public class MainClass
{
    public static void Main()
    {
        string s  = Console.ReadLine();
        int nu = 0;
        for( int i=0; i<s.Length; i++)
       if(s[i]>='a' && s[i]<='z' || s[i]>='A' && s[i]<='Z' || s[i] >= '0' && s[i] <= '9' && s[i] != 0 || s[i] == '_')
          nu++;           
        if (nu == s.Length)
          Console.WriteLine("YES");   
      
        else Console.WriteLine("NO");
           
    }        
        
 }
