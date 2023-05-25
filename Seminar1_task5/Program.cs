// Напишите программу, которая принимает на вход целое число любой разрядности
//  и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. 
//  Через строку решать нельзя.

System.Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num /=  10;
    }
    System.Console.WriteLine(num % 10);
}