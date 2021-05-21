using System;

public class MainClass
{
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
         string [] ss = Console.ReadLine().Split(' ');
          int [] number = new int [n];
           int age = Convert.ToInt32(Console.ReadLine());
            int count=1;
       for(int i = 0;i<n;i++)
       {
           number [i]=Convert.ToInt32(ss[i]);
       }
        for(int i = 0;i<n;i++)
          
          if(age<number[i]  || age==number[i])
          
             count++;
        {  
            Console.Write(count + " ");
        } 
    }
}
