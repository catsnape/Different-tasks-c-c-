using System;

public class MainClass
{
    public static void Main()
    {
       int y=Convert.ToInt32(Console.ReadLine());
       int a=0;int b=0; int c=0; int d=0;
        for(int i=y+1;i<=90000;i++){
           a = i / 1000;
           b = (i / 100) % 10;
           c = (i / 10) % 10;
           d = i % 10;
             if (a != b && a != c && a != d && b != c && b != d && c != d)
                { 
                    Console.WriteLine(i);
                         break; 
                }
        } 
              
    }
}
