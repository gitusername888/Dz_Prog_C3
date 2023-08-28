// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoords(int x, int y)
// {
//     if (x > 0 && y > 0)
//         System.Console.WriteLine("это первая четверть");
//     else if (x > 0 && y < 0)
//         System.Console.WriteLine("это четвертая четверть");   
//     else if (x < 0 && y < 0)
//         System.Console.WriteLine("это третья четверть");   
//     else if (x < 0 && y > 0)
//         System.Console.WriteLine("это вторая четверть"); 
//     else
//         System.Console.WriteLine("точка лежит на координатной оси");
// }

// int CheckKoords2(int x, int y)
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result = 4; 
//     else if (x < 0 && y < 0)
//         result = 3; 
//     else if (x < 0 && y > 0)
//         result = 2;
//     return result;
// }


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32( Console.ReadLine() );
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32( Console.ReadLine() );
// CheckKoords(x, y);
// System.Console.WriteLine( $"это четверть № {CheckKoords2(x, y)}");

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32( Console.ReadLine() );


bool IsPalindrome (int number)
{
int condition1 = number/10000;
int condition2 = number/1000 - condition1*10;
int condition3 = number%100/10;
int condition4 = number%10;
int condition5 = number - 9999;

if ( condition5 > 0 & condition5 < 99999)
{
    if ( condition1 == condition4 & condition2 == condition3) 
    {
        Console.Write($"{number} -> ");
        return true;
        
    }
    else 
    {
        Console.Write($"{number} -> ");
        return false;
    }
}
else
{
   Console.WriteLine($"{number} -> Число не пятизначное");
    return false;
}
}


// if (args.Length == 5) {
//             number1 = int.Parse(args[0]);
//             number2 = int.Parse(args[1]);
//             number3 = int.Parse(args[2]);
//             number4 = int.Parse(args[3]);
//             number5 = int.Parse(args[4]);
//         } else {
           
//             number = 64546;
//         }


bool result = IsPalindrome(number);

Console.WriteLine($"{result}");

