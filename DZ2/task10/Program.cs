// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное целое число");
int num = Convert.ToInt32( Console.ReadLine() );


int digital1 = num % 100;
int digital2 = num % 10;
int dig = (digital1 - digital2)/10;


Console.WriteLine ($"{num} -> {dig}");
