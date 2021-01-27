using System;

public class MainClass
{
    public static void Main()
    {
        double n = Convert.ToInt32(Console.ReadLine());//Первый ввод
            double summ = 0;//Сумматор            
            double count = 0;//Счетчик
            while (n != 0)
            {
                count++;//Ставим счетчик и сумматор сверху над повторным вводом чтоб учитывать первое число
                summ = summ + n;
                n = Convert.ToInt32(Console.ReadLine());//Повторный ввод
            }
            Console.WriteLine(summ / count);// Делим сууму чисел, на их количество
       
    }
}
