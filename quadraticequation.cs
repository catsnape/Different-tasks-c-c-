using System;

public class MainClass
{
    public static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double d = b*b - 4*a*c;
        if (d > 0) {
            double x = (-b-Math.Sqrt(d))/2/a;
            double y = (-b+Math.Sqrt(d))/2/a;
            if (x < y) {
                Console.WriteLine(x);
                Console.WriteLine(y);
            } else {
                Console.WriteLine(y);
                Console.WriteLine(x);
            }
        } else if (d == 0)
            Console.Write(-b/2/a);
    }
}
