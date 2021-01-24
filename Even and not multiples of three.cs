using System;

public class MainClass
{
    public static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int count=0;
        while(n!=0)
        {   if (n % 3 != 0 && n % 2 == 0)
            count=count+n;
            n=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(count);
    }
}
