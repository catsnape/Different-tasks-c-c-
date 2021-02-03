using System;

public class MainClass
{
    public static void Main()
    {
         int n = Convert.ToInt32(Console.ReadLine());
int sum;
int i = 0; // счётчик
int a = 0; // переменная для учета предыдущего значения n
while (n != 0)
{
     sum = n - a; // разность последовательных чисел
    if(sum > 0)
    {
          i++; // если предыдущее число меньше, увеличиваем счётчик
    }
    a = n; // записываем для a текущее значение n, в новом круге станет предыдущим
      n = Convert.ToInt32(Console.ReadLine()); // вводим следующее значение n
}
Console.WriteLine(i-1); // т.к. первый круг учитывать не нужно в итоге (i-1)
    }
}
