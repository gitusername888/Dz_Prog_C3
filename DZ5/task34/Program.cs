// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,999);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (int item in array)
        System.Console.Write($" ,{item}");
    System.Console.Write("]");
}

int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2  == 0)
        count = count + 1;
    return count;
}

Console.WriteLine("Введите колличество числел в массиве");
int number = Convert.ToInt32( Console.ReadLine() );

int[] array = new int[number];

FillArray(array);
PrintArray(array);
System.Console.WriteLine($" -> {Even(array)}");
