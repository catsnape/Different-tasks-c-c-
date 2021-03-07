using System;

public class MainClass
{
    public static void Main()
    {
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int mult=a;
        for(int i=a;i<=b;i++){
         if(i%7==0) 
         {
             mult=i;
         }
        }
        if (mult%7==0)
        {
            Console.Write(mult);
        }
        else
        {
           Console.Write("NO"); 
        }
        
    }
}
