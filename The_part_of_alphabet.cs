using System;

public class MainClass
{
    public static void Main()
    {
       char a = char.Parse(Console.ReadLine());
       char z = char.Parse(Console.ReadLine());
        
        for(int i = 'a'; i<='z'; i++)
            if (i==a && i==z || i<=z && i>= a || i>=z && i <=a)
                
                Console.Write((char)i + " ");
    }
}
