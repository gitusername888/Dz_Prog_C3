﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandomMatrix(int m, int n, int z, int minLimitRandom, int maxLimitRandom)
{

    int[,,] matrix = new int[m, n,z];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++ ) matrix[i, j, k] = new Random().Next(minLimitRandom, maxLimitRandom);
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            
            System.Console.WriteLine();
        }
        
    }

}



int m = 2;
int n = 2;
int z = 2;
int minLimitRandom = 10;
int maxLimitRandom = 99;

int[,,] value1 = CreateRandomMatrix(m, n,z, minLimitRandom, maxLimitRandom);
PrintArray(value1);
System.Console.WriteLine("");