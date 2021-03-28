using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
        string s = Console.ReadLine();
           string[] ss = s.Split(' ');
       
          int[] numbers = new int[n]; // заводим новый массив целого типа

           for (int i = 0; i < n; i++) // так как у нас в массиве n чисел, то проходим по нему циклом
          {
            int number = Convert.ToInt32(ss[i]); // конвертируем в число
                numbers[i] = number; // записываем в соответствующее место сконвертированное число 
               if(numbers[i] %3==0)
            Console.Write(numbers[i]+ " "); 
          }

       
     }
}
