using System;

public class MainClass
{
    public static void Main()
    {
        int n= Convert.ToInt32(Console.ReadLine()); 
         while(n>0)
         { 
         int sum =n%10;
           Console.Write(sum); 
           n=n/10;
        }
        
    }
    
}
