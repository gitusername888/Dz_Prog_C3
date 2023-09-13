// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            System.Console.Write($"{matrix[i, j]}\t");
        System.Console.WriteLine();
    }

}

int[] TempArray(int[,] array)
{
    int index = 0;
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1)];
    foreach (int number in array)
    {
        tempArray[index] = number;
        index++;
    }
    return tempArray;

}






int[] SortArray(int[,] array, int[] tempArray, int m, int n)
{
    int count = 0;


    int temp;
    for (int j = 0; j < tempArray.Length; j = j + n)
    {
        count = 0;
        while (count < n - 1)
        {
            for (int i = 0 + j; i < n - 1 + j; i++)
            {
                if (tempArray[i] < tempArray[i + 1])
                {
                    temp = tempArray[i];
                    tempArray[i] = tempArray[i + 1];
                    tempArray[i + 1] = temp;
                }
            }
            count++;
        }
    }

    return tempArray;
}

int[,] ChangeArray(int[] tempArray, int m, int n)
{
    int[,] array = new int[m, n];
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = tempArray[index];
            index++;
        }
    }
    return array;
}


int m = 3;
int n = 4;
int minLimitRandom = 0;
int maxLimitRandom = 10;

int[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(result);
int[] tempArray = TempArray(result);
int[] result1 = SortArray(result, tempArray, m, n);
int[,] result2 = ChangeArray(result1, m, n);
System.Console.WriteLine(" ");
PrintArray(result2);