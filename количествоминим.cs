using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int min = 1000001;
        int cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == min) cnt++;
            if (a<min) 
            {
                min = a;
                cnt = 1;
            }
        }
        Console.WriteLine(cnt);
    }
}
