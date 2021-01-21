using System;

public class MainClass
{
    public static void Main()
    {
         int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            while (n != k)
            {
                if (n > k) n = n - k;
                if (n < k) k = k - n;
            }
            Console.WriteLine(n);
    }
}
