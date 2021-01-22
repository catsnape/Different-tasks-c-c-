using System;

public class MainClass
{
    public static void Main()
    {
       int n=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        
        while(n>0)
        { 
            int x= n%10;
            if(x==4)
             sum=sum + 1;
             n=n/10;
        }
        Console.WriteLine(sum);
    }
  
}
   
