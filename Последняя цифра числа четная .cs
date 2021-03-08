using System;

public class MainClass
{
    public static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int a=0;
       a=n%10;
        n=n/10;
            if (a%2==0)
            {  Console.WriteLine("YES");}
        else 
        { Console.WriteLine("NO");}
    }
}
