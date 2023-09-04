// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] InputNumbers (int[] array)
{
    int count = array.Length;
    int num = 0;
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine($"Введите чисело {i}");
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
int PositiveCont (int [] array)
{
    int countPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array [i] > 0)
     countPositiv++ ; 
        }
        return countPositiv;
}


System.Console.WriteLine("Введите количество чисел М");
int M = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[M];
InputNumbers (array);
PrintArray (array);
System.Console.WriteLine($"-> {PositiveCont (array)}");
