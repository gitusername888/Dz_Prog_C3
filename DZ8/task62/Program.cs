// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiraleMatrix(int m)
{

    int[,] matrix = new int[m, m];

    int startNumber = 1;
    while (startNumber < m * m)
    {

        for (int i = 0; i < m / 2; i++)
        {
            for (int j = i; j < m - i; j++) matrix[i, j] = startNumber++;
            for (int j = i; j < m - i - 1; j++) matrix[j + 1, m - 1 - i] = startNumber++;
            for (int j = m - i - 1; j > i; j--) matrix[m - i - 1, j - 1] = startNumber++;
            for (int j = m - i - 2; j > i; j--) matrix[j, i] = startNumber++;

        }
        if (m % 2 != 0) matrix[m / 2, m / 2] = m * m;
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

System.Console.WriteLine("Введите число сторон квадарата:");
int m = int.Parse(Console.ReadLine()!);

int[,] result = CreateSpiraleMatrix(m);
PrintArray(result);