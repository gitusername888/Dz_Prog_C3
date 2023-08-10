// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающую день недели:");
int num = Convert.ToInt32( Console.ReadLine() );


if (num > 5 && num <8 )
Console.WriteLine($"{num} -> да");
else
Console.WriteLine($"{num} -> нет");