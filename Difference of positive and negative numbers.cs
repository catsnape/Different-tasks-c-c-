using System;

public class MainClass
{
    public static void Main()
    {
       int n=Convert.ToInt32(Console.ReadLine());
        int razn=0;
        while(n!=0)
        {  
         if(n>0)
            {
             razn++;
            n=Convert.ToInt32(Console.ReadLine());
            }
         else 
            {
            razn--;
            n=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(razn); 
    }
}
