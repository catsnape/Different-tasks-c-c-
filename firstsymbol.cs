using System;

public class MainClass
{
    public static void Main()
    {
       string str = Console.ReadLine();
      
        for(int i=0;i<str.Length;i++)
        {
       
            if(str[i] == 'w' || str[i] == 'x')
            {
                Console.WriteLine(str[i]);
                break;
            }
           
            if(i == str.Length-1)
            {
               Console.WriteLine("-1");
            }
        } 
    }
}
