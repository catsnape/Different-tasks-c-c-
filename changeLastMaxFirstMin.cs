using System;

public class MainClass
{
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
              String s = Console.ReadLine(); 
              string [] ss = s.Split(' ');
              
       
       
        int[] numbers = new int [ss.Length];
        for (int i =0;i<numbers.Length;i++)
        {
            int number = Convert.ToInt32(ss[i]);
               numbers[i] = number;   
        } 
        int tmp = 0;
        int minInd = 0;
        int maxInd = 0;
        int min = numbers[0];
         int max = numbers[0];
        for (int i = 1;i<numbers.Length;i++)
        {
            if(min>numbers[i])
           {
              min = numbers[i]; 
                minInd=i;    
           }  
         
            if(max<=numbers[i])
            { 
              max = numbers[i];
              maxInd=i;
            }
         }
            tmp = numbers[minInd];
             numbers[minInd] = numbers[maxInd];
               numbers[maxInd] = tmp;
         
        for(int i = 0;i<n;i++)  
        {
            Console.Write(numbers[i]+ " ");
        }
         
    }
}
