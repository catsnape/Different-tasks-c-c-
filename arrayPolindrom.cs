using System;

public class MainClass
{
    public static void Main()
    {
         int n = Convert.ToInt32(Console.ReadLine());
         string [] ss = Console.ReadLine().Split( );
        int [] numbers = new int [n];
        int cnt=0;
        for (int i = 0;i<n;i++)
        {   
            int  number = Convert.ToInt32(ss[i]);
            numbers [i] = number;
         } 
        
        for (int i=0;i<n/2;i++)
        {
          if
           (numbers[i]!=numbers[n-1-i])
           {  
               cnt++;
           }
        }
             if(cnt!=0)   
          {
            Console.Write("NO");
          }
        else 
        {
            Console.Write("YES");
        }                     
    }
}
