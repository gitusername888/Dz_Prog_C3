// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int PrintNumbers(int m, int n)
{ 
     if (n < m) 
        return n=0; 
    return n + PrintNumbers(m, n - 1) ; 
 
} 
 
System.Console.WriteLine("Введите натуральное число M"); 
int n = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите натуральное число N"); 
int m = Convert.ToInt32(Console.ReadLine()); 


System.Console.WriteLine($"M = {m}; N = {n} -> \"{PrintNumbers(n,m)}\"");
