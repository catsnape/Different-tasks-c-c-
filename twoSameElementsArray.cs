using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ss = Console.ReadLine().Split();
        for (int i = 0; i < ss.Length; i++)
        {
            int count = 0;
            for (int j = i + 1; j < ss.Length; j++)
            {
                if (j!=i && ss[i] == ss[j])
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
        }
        Console.WriteLine("NO");
    }
}
