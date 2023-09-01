// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

// необязательная задача SORT Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N 
// с клавиатуры, далее заполняется случайными целыми числами от -100 до 100, выводится на экран. Сортируется, и затем опять выводится на экран.



int[] CreateArray() 
{ 
    int[] array = new int[8]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        Random rnd = new Random(); 
        array[i] = rnd.Next(1, 50); 
    } 
    return array; 
} 
 
void PrintArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.Write($"{array[i]} " ); 
    } 
} 




PrintArray(CreateArray());