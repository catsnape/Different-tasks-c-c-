using System;

public class MainClass
{
    static  int  ComparisonNumOfDigitsFunct(int number)
    {
        int count = 0;
       
        while(number!=0)
        {
            number=number/10;
            count++;
        }
        return count;
    }
    public static void Main()
    {
        int FirstNaturalNumber = ComparisonNumOfDigitsFunct(Convert.ToInt32(Console.ReadLine()));
        int SecondNaturalNumber = ComparisonNumOfDigitsFunct(Convert.ToInt32(Console.ReadLine()));
        if (FirstNaturalNumber>SecondNaturalNumber)
        {  Console.WriteLine("1");}
        if (FirstNaturalNumber<SecondNaturalNumber)
        { Console.WriteLine("2");}
        if (FirstNaturalNumber == SecondNaturalNumber)
         Console.WriteLine("0");
    }
}
