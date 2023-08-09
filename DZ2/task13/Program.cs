// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32( Console.ReadLine() );


int digital1 = num % 100;
int digital2 = num % 10;
int dig = (digital1 - digital2)/10;


Console.WriteLine ($"{num} -> {dig}");
