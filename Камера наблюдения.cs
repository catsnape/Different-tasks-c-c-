using System;

   public class MainClass
  {
    public static void Main()
    {
            int n = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            string s = " NO";
            int max = number;
            for (int i = 0; i < n; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 30)
                {
                    s = " YES";
                }
                if (number > max) 
                {
                    max = number;
                }
            }
            Console.WriteLine(max + s);
    }
}
