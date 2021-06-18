using System;

public class MainClass
{
    static int  doubleFactorialFunct(int funct)
    {
       for (int i = funct-2; i > 0; i -= 2)
            funct*=i;
        
        return funct;
    }    
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
       
        Console.Write($"{doubleFactorialFunct(a)} {doubleFactorialFunct(b)} {doubleFactorialFunct(c)} ");
           
    }
}
