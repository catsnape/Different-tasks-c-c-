using System;

public class MainClass
{
    public static void Main()
    {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0; // сумматор
            int h = n;
            while (h > 0) // пока цифры числа не закончатся
            {
                int digit = h % 10; // последняя цифра числа
                sum = sum + digit; // складываем в сумматор
                h = h / 10; // избавляемся от последней цифры.
            }
            if (n % sum == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
    }
}
