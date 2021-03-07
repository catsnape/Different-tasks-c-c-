using System;

public class MainClass
{
    public static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int x=0;
        int sum=0;int s=0;
       while(n!=0){
           x=Convert.ToInt32(Console.ReadLine());
           x=n%10; sum=sum+x;n=n/10;
           if(sum>=10 && n==0)
             {
			         	n = sum;//присваиваем значение суммы чисел, опять заходим в цикл
				       sum = 0;//обнуляем сумму
			       }
       
     }
        
         Console.WriteLine(sum);
   }
}
