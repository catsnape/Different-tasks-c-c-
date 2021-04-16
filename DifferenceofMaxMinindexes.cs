using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        string[]ss = s.Split(' ');
        int [] numbers = new int[n];
       
        for (int i = 0;i<n;i++)
        {
            int number = Convert.ToInt32(ss[i]);
            numbers[i] = number;
        }
        int min = numbers[0];
        int indexMin = 0;
        for (int i = 1;i<n;i++)
        {
            if(numbers[i]<min)
           {
              min = numbers[i];
                indexMin = i;
           }  
         } 
        int max = numbers[0];
        int indexMax = 0;
        for(int i = 1; i<n;i++)
            if(numbers[i]>max)
           { 
             max = numbers[i];
               indexMax=i;
            }
                
       Console.WriteLine(indexMax-indexMin);
    }
}
