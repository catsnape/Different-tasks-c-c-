using System;

public class MainClass
{
    static int ReverseNum(int number)
    {
       string s = " ";
			while ( number != 0) 
            { 
                s = s + number % 10 ; 
                number /= 10;
            }
			return Convert.ToInt32(s);
    }
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
         int m = Convert.ToInt32(Console.ReadLine());
           int sum = (ReverseNum(n)+ReverseNum(m));
           
               Console.WriteLine(sum);
    }
}
