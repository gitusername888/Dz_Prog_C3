// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    // Введите свое решение ниже
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minLimitRandom, maxLimitRandom);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write($"{matrix[i, j], 1} ");
        System.Console.WriteLine();
    }

}

int [] NumberRow (int[,] matrix )
{
    int sumRow = 0;
      int rows = matrix.GetUpperBound(0) + 1;    // количество строк
  int columns = matrix.Length / rows; 
  int [] sumArray = new int [rows];       // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        sumRow = 0;
        for (int j = 0; j < columns; j++)
            sumRow = sumRow + matrix [i,j];
        // sumArray [i] = sumRow;
        sumArray [i] = sumRow;
        System.Console.WriteLine($"Сумма {i+1} строки = {sumRow}");

    }
    // int numberRow = anArray.ToList().IndexOf(maxValue);
    // System.Console.WriteLine($"{numberRow} строка})
return sumArray;
}

void FindMaxIndex(int [] sumArray)
{
int maxValue  = sumArray.Max();
int result = 0;
for (int i=0; i < sumArray.Length; i++)
if (sumArray[i] == maxValue) result = i+1;


System.Console.WriteLine($"{result} строка");
}

int m = 4;
int n = 4;
int minLimitRandom = 0;
int maxLimitRandom = 10;

int[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(result);
int[] sumArray = NumberRow (result);
FindMaxIndex(sumArray);

