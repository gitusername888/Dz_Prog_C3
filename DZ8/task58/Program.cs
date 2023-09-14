// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            System.Console.Write($"{matrix[i, j], 2}  ");
        System.Console.WriteLine();
    }

}


void MatrixMultiplication (int[,] value1, int[,] value2 )
{
    // int[,] matrixMultiplication = new int [value1.GetLength(0), value1.GetLength(1)];
    // int multiplication = 0;
    int j = 0;
     int i = 0;
        
            int multiplication1 = value1[i,j]*value2[i,j]+value1[i,j+1]*value2[i+1,j];
            int multiplication2 = value1[i,j]*value2[i,j+1]+value1[i,j+1]*value2[i+1,j+1];
            int multiplication3 = value1[i+1,j]*value2[i,j]+value1[i+1,j+1]*value2[i+1,j];
            int multiplication4 = value1[i+1,j]*value2[i,j+1]+value1[i+1,j+1]*value2[i+1,j+1];

            System.Console.WriteLine("");
            System.Console.WriteLine($"{multiplication1} {multiplication2}");
            System.Console.WriteLine($"{multiplication3} {multiplication4}");
       
        System.Console.WriteLine();
    

// return matrixMultiplication;

}


int m = 2;
int n = 2;
int minLimitRandom = 0;
int maxLimitRandom = 10;

int[,] value1 = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(value1);
System.Console.WriteLine("");
int[,] value2 = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(value2);
 MatrixMultiplication (value1, value2);
// PrintArray(matrixMultiplication);