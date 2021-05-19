using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string [] ss = Console.ReadLine().Split(' ');
        int [] numbers =  new int [n];
        int sum = 0;
        for (int i = 0;i < n; i++ )
        
            numbers[i]=Convert.ToInt32(ss[i]);
        for (int i = 1;i < n; i++)
        {
          if (numbers[i-1]<numbers[i])
          {
            sum++;     
          }
        }
            Console.WriteLine(sum);
    }
}
