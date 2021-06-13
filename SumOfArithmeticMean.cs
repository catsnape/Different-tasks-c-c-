using System;

public class MainClass
{
    static double Sum (double number)
 {
     double count =0;  
     double sum = 0;
   for (double i = 0; i <= number; i++)
   {
    count = count+i;
       sum = count/number; 
   }
     return sum;      
 }  
   static void Main(string[] args)
  {
     double n = Convert.ToInt32(Console.ReadLine());
      double m = Convert.ToInt32(Console.ReadLine());
        double arithMean = (Sum(n)+Sum(m));
  
             Console.WriteLine(arithMean);

  } 
}
