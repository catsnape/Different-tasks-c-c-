using System;

public class MainClass
{
    public static void Main()
    {
int n = Convert.ToInt32(Console.ReadLine());// исходное
int dup=n;// создаём дублёр для изменения
int p=0; //создаём  перевёртыш
while (dup>0)// пока у дублёра не останется  разрядов
{
p=p*10+dup%10; // вложили в перевёртыш последнию цифру дублёра 
dup= dup/10; // убрали у дублёра последнию цифру
}
if (n==p){Console.WriteLine("YES");}
else {Console.WriteLine("NO");}
    }
}
