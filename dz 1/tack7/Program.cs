// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
int result1 = Math.Sign(num1); //-1
int i = 0;
if (result1 == -1) {
    num1 = num1*-1;
}
if (num1/10 >= 10)
{
    // if (num1/10 >= 10)
    // {

    // }
   int k = num1/10;
    while (k > 99)
    {
        k = k/10;
        i++;
    }
    double num2 = Math.Pow(10, i);
    
    double num3 = Math.Floor(num1/num2);
    int num4 = Convert.ToInt32 (num3);
    int ost100 = num4%10;
    
    
    Console.WriteLine($"{num1} -> {ost100}");
} 
else 
{
    Console.WriteLine($"{num1} -> нет ");
}