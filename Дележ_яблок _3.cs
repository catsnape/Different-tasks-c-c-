using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write((n - k % n) % n);
    }
}
