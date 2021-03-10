using System;

public class MainClass
{
    public static void Main()
    {
        char c = Convert.ToChar(Console.ReadLine());
        if (c>='a' && c<='z') {
            int number = c-'a';
            Console.WriteLine((char)('A'+number));
        }
        if (c>='A' && c<='Z') {
            int number = c-'A';
            Console.WriteLine((char)('a'+number));
        }
        // put your c# code here
    }
}
