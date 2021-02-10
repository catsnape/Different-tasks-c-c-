using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        while(n!=1)
        {
           while(n%i==0)
           {
               Console.Write(i + " ");
               n=n/i;
           }
            i++;
        }
    }
}
