// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 1;
if (num1 > num2)
{
    if (num1 > num3)
    {

        max = num1;
    }
    else
    {
        max = num3;
    }
}

else
{
    if (num2 > num3)
    {

        max = num2;
    }
    else
    {
        max = num3;
    }
}

Console.WriteLine($"{num1} {num2} {num3} -> max = {max}");