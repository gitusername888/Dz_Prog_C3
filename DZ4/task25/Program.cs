// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static void ShowCube(int numberA, int numberB)
    {
      // Введите свое решение ниже

        double increment = Math.Pow(numberA, numberB);
        System.Console.WriteLine($"{numberA}, {numberB} -> {increment}");
    
    }



Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32( Console.ReadLine() );

        ShowCube(numberA, numberB);