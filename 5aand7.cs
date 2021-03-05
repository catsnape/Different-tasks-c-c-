using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = "";
        while (n != 0)
        {
            if (n % 10 == 7 || n % 10 == 5)
                n = n / 10;
            else 
            {
                s = n%10 + s;
                n = n / 10;
            }
        }
        Console.WriteLine(s);
    }
}
