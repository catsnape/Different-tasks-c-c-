using System;

public class MainClass
{
    public static void Main()
    {
        int a= Convert.ToInt32(Console.ReadLine());
        int b= Convert.ToInt32(Console.ReadLine());
        int k= Convert.ToInt32(Console.ReadLine());
        int cnt=0;
        
     for(int i=a; i<=b; i++)
     { 
       for(int z=1; z<=i; z++)
      {
             if(i%z==0)
         {
             cnt++;
         }
      }
          if(cnt>=k)
         {
             Console.Write(i+" ");
         }
         cnt=0;
     }

    }
}
