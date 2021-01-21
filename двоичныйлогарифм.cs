using System;

public class MainClass
{
    public static void Main()
      {
            int n = Convert.ToInt32(Console.ReadLine());

            int stepen = 1;
            int k = 0;
            
          
            while (stepen < n)
            {
               
                stepen = 2*stepen;
                k++;  
            }
  Console.WriteLine(k);
    }
}
