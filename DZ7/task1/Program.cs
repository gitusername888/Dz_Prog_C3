


 double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
    double[, ] matrix = new double [m,n];
    int t = 0;
     for (int i = 0; i < m; i++)
     {
        for (int j = 0; j < n; j++)
        {t = new Random().Next(minLimitRandom,maxLimitRandom);
        matrix [i,j] = new Random().NextDouble()*t;
           }
     }
 return matrix; 
  }

   void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
  for (int i = 0; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write($"{matrix[i,j]:f2}\t");
        System.Console.WriteLine();
        }
   
  }

 
      int m = 3;
      int n = 4;
      int minLimitRandom = -10;
      int maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
 
