using System;

public class MainClass
{
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
           string[] ss = s.Split(' ');
        int [] numbers = new int [n];
        int sum=0;
        for (int i = 0;i < n;i++)
        {
            numbers[i] = Convert.ToInt32(ss[i]);
            if (numbers[i]%2==0)
            {  
                Console.Write(ss[i] + " " );
                sum++;
            }
        }
         Console.WriteLine();
            Console.WriteLine(sum);
    }
}
