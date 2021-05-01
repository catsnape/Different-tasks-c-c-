using System;

public class MainClass
{
    public static void Main()
    {
     int n = Convert.ToInt32(Console.ReadLine());  
        string [] ss  = Console.ReadLine().Split(' ');
         for (int i = 0;i<ss.Length;i++)
         {
             int count = 0; 
            for (int j = 0;j<ss.Length;j++)
            {
                if(ss[i]==ss[j] && i!=j)
                { 
                  count++;
                     break; 
                }
            }  
             if(count==0)
            Console.Write(ss[i] + " ");
         }
        
    }
}
