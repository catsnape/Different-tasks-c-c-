using System;

   public class MainClass
   {
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
         string s = Console.ReadLine(); // сохранить все введенную строку
          string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа

      int[] numbers = new int[n];
        int min = 10000;
       for (int i = 0; i < n; i++)
      {
           int number = Convert.ToInt32(ss[i]);
             numbers[i] = number;
       }
              
       for (int i = 0; i < n; i++)
      {
           if (numbers[i] < min)
        
            min = numbers[i];
       }
       for(int i = 0; i < n; i++)
        {
            numbers[i] = numbers[i] - min;
            Console.Write(numbers[i] + " ");
        }
      
    } 
 }
