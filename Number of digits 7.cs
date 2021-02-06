using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j != 0; j =j/ 10)
                if (j % 10 == 7) count++;
        }
        
        Console.WriteLine(count);
    }
}
