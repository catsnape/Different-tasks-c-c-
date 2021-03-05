using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int s = 1;
        for (int i = 1; i <= n; i++)
            s =s* a;
        Console.Write(s);
    }
}
