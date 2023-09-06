// ** Задача ДОП по желанию ** .
// Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

// Пример:

// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]


int [] Factorial(int[] array){
    int[] arraySum = new int[array.Length];
        
        int factorial = 1;
        arraySum[0] = 1;
        
        if (array.Length == 1) return arraySum;
        else {
            arraySum[1] = 1;
        for (int i = 2; i < array.Length ; i++){
            factorial = factorial + arraySum[i-2];
            arraySum[i] = factorial; 
        }
        }
    
    return arraySum;
}


int [] NegativeArray(int[] factorial)
{
    int buf;
    int[] arrayNegative = new int[factorial.Length];
    for (int i = 0; i < factorial.Length ; i++)
    {
        buf = factorial[factorial.Length - i-1]*-1;
        arrayNegative[i] = buf;
        
        
    }
    return arrayNegative;
}
void PrintArray(int[] array)
{
    
    foreach (int item in array)
        System.Console.Write($"{item}, ");
    
}

System.Console.WriteLine("Введите количество чисел М");
int M = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[M];
int [] factorial = Factorial(array);

int [] negative = NegativeArray(factorial);
System.Console.Write($"для k = {M} список будет выглядеть так: [");
PrintArray(negative);
System.Console.Write("0, ");
PrintArray(factorial);
System.Console.Write("]  [Негафибоначчи]");