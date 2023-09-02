// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble()*100;
}

void PrintArray(double [] array)
{
    System.Console.Write("[");
    foreach (double item in array)
        System.Console.Write(" {0,2:N2}", item);
    System.Console.Write("]");
}


Console.WriteLine("Введите колличество числел в массиве");
int number = Convert.ToInt32( Console.ReadLine() );

double[] array = new double [number];

FillArray(array);
PrintArray(array);
double sum = array.Max() - array.Min();
// System.Console.WriteLine($" -> {Even(array)}");
System.Console.Write($" => ");
System.Console.Write("{0,1:N2}", array.Max());
System.Console.Write(" - ");
System.Console.Write("{0,1:N2}", array.Min());
System.Console.Write(" = {0,1:N2}", sum);


