using System;

public class MainClass
{
    public static void Main()
    {
      int n = Convert.ToInt32(Console.ReadLine());
        int a = 1; // вспомогтельная переменная, дублирующая переменную i
        int b = 1; // вспомогательная переменная, хранящая последнюю цифру числа
        int c = 0; // сумматор цифр числа
        int d = 1; // вспомогательная переменная, хранящая наибольшую сумму цифр
        int e = 1; // вспомогательная переменная, хранящая наименьшее число с наибольшей суммой цифр
        for (int i = n; i >= 1; i--) // перебираем числа от n до 1
        {
            c = 0;
            a = i;
            while (a > 0) // суммируем цифры каждого числа в переменную c
            {
                b = a % 10; // в b последняя цифра
                c = c + b; // суммируются цифры в c
                a = a / 10; // в a избавляемся от последней цифры числа
            }
            if (c > d)
            {
                d = c; // тут дожна быть сумма цифр
                e = i; // тут должно быть число
            }
        }
        Console.Write(e + " " + d);
    }
}
