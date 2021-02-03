using System;

public class MainClass
{
    public static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        int k=n;
        while(n!=0)
        {
           if(k<0&&n>0||k>0&&n<0)
           {
               sum=sum+1;
            }
            k=n;
           n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(sum);  
    }   
}
