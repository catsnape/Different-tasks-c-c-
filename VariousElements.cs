using System;

public class MainClass
{
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
        string []ss = Console.ReadLine().Split(' ');
        int[] numb = new int [n];
        int cnt=1;
        for (int i =0;i<n;i++)
        {
            numb [i] = Convert.ToInt32(ss[i]);
        }
        for (int i = 1;i<n;i++)
            if (numb[i-1]!=numb[i])
              cnt++;
        Console.WriteLine(cnt);
    }
}
  
