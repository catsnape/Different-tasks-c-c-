

using System;

namespace ConsoleApp
{
static int Factorial(int number)
 {
   int fact = 1;
   for (int i = 1; i <= number; i++)
   {
     fact = fact * i;
   }
   return fact;
}

static void Main(string[] args)
{
   int n = Convert.ToInt32(Console.ReadLine());
   int k = Convert.ToInt32(Console.ReadLine());

   int factN = Factorial(n);
   int factK = Factorial(k);
   int nSubtractK = n - k;
   int factNSubtractK = Factorial(nSubtractK);
  
   Console.WriteLine(factN / (factK * factNSubtractK));
 } 
}
