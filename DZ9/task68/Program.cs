// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Ask(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ask(m - 1, 1);
    else
        return Ask(m-1, Ask(m, n-1));
}

System.Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = {Ask(m, n)}");
