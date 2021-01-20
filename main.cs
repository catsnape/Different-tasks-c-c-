using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()); // ввод числа, до которого должны выводится все степени двойки
		double i = 1; // переменная, в которой будут храниться значения (начинается с одного, на 0 нельзя умножить)
		
		while (i <= n) // цикл пока мультипликатор не больше н
		{
			Console.WriteLine(i); // выводим переменную
			i = i * 2; // перемножаем ее на 2 ( 1 * 2 == 2, 2 * 2 == 4 etc.)
		}
    }
}