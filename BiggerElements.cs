using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int cnt = 0;
        for(int i = 1;i<n;i++)
        {
            int num1 = Convert.ToInt32(s[i-1]);
            int num2 = Convert.ToInt32(s[i]);
           if(num1<num2){cnt++;}
        }
        Console.Write(cnt);
    }
}
