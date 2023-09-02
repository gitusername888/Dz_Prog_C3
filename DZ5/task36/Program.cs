// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
}

int Even(int[] array)
{
    
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2  != 0)
        sum = sum + array[i];
    return sum;
}

Console.WriteLine("Введите колличество числел в массиве");
int number = Convert.ToInt32( Console.ReadLine() );

int[] array = new int[number];

FillArray(array);
PrintArray(array);
System.Console.WriteLine($" -> {Even(array)}");