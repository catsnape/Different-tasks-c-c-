using System;

public class MainClass
{
    public static void Main()
    {
        string str = Console.ReadLine();  
        for (int i = 0;i<str.Length;i++){
            if(str[i]>='0' && str[i]<='9')
            {  
                Console.Write(str[i] + " ");
            }
       }
    }
}
