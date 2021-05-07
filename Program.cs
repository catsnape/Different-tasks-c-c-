using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()); // число строк
        int[,] a = new int[n, n]; // создание массива


        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n ; j++)
            {
                if (i == n - j - 1) a[i, j] = 1;
                else if (i > n - j - 1) a[i, j] = 2;
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}