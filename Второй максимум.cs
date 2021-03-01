using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        while(n != 0)
        {
            list.Add(n);
            n = int.Parse(Console.ReadLine());
        }
        list.Sort();
        Console.WriteLine(list[list.Count - 2]);
    }
}
