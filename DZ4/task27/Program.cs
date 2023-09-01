// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int digitnum (int num)
{
    int x = 0;
    int count = 1;
    int num1 = num;
    int sum =0;
    int x1 = 0;
    int x2 = 0;
    while (num/10 != 0)
    {
        num = num/10;
        count=count+1;
    }
    
    for (int j = 0; j < count; j++)
   
 {
    x1 = Convert.ToInt32(Math.Floor(num1/Math.Pow (10,j)));
    x2 = Convert.ToInt32(Math.Floor(num1/Math.Pow (10,j+1))*10);
    
    x = x1 - x2;    
           
    sum = x + sum;
            

}
return sum;
}



System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{num} ->{digitnum(num)}");

