using System;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        int n, count;
        n = Convert.ToInt32(Console.ReadLine());
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        count = nums.Count(x => x % 3 == 0 && x % 10 == 7);
        nums = nums.Select(x => x = x % 3 == 0 && x % 10 == 7 ? count : x).ToArray();
        
        Console.Write(string.Join(" ", nums));  
    }
}
