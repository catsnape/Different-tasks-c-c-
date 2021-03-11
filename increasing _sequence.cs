using System;

public class MainClass
{
    public static void Main()
    {
        int f=Convert.ToInt32(Console.ReadLine());
        int c = f % 10; // 3 
            int a = f / 100; // 1
            int d = f % 100; // 23
            int b = d / 10; //2
            if (a < b && b < c && c > a){ 
           Console.WriteLine("YES");
            }
             else {
            Console.WriteLine("NO");
             }
        
        }
}
