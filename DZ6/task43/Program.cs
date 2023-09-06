// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int [] InputNumbers (int[] array)
{
    int count = array.Length;
    int num = 0;
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine($"Введите число {i}");
        num = Convert.ToInt32 (Console.ReadLine ());
        array [i] = num;
    }
    return array;
}


void PrintArray(int[] array)
{
    
    foreach (int item in array)
        System.Console.Write($"{item}, ");
    
}
void Processor (int [] array)
{
   
    
   
    if (array [1] != array [3])
    {
        //double x = (array[2] - array[0])/(array[1] - array[3]);
        double num1 = (array[2] - array[0]);
        double num2 = (array[1] - array[3]);
        double x = num1/num2;
        double y = x*array[1] + array[0];
        System.Console.WriteLine($"-> ( {x} {y} )");
    }
    else
    System.Console.WriteLine("Линии параллельны");
}




int[] array = new int[4];
InputNumbers (array);
PrintArray (array);
Processor (array);