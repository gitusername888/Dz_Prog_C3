// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
//  и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




 double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        int x = (pointB[0]-pointA[0])*(pointB[0]-pointA[0]);
        int y = (pointB[1]-pointA[1])*(pointB[1]-pointA[1]);
        int z = (pointB[2]-pointA[2])*(pointB[2]-pointA[2]);

      return Math.Sqrt(x+y+z);
    //   return Math.Sqrt((pointB[0]-pointA[0])*(pointB[0]-pointA[0]) + (pointB[1]-pointA[1])*(pointB[1]-pointA[2]) + (pointB[2]-pointA[2])*(pointB[2]-pointA[2]));

    }

 

        // Не удаляйте строки ниже
        double result = Length(new int[]{3, 6, 8}, new int[]{2, 1, -7});
        Console.WriteLine($"{result:F2}");
        
        