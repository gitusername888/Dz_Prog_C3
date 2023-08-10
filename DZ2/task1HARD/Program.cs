// задача 1 необязательная

// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 1,45 -> 1,5
// 1 -> нет
// 567,123 -> 57,123




Console.WriteLine("Введите число");

string st = Console.ReadLine();
char [] array;
for(var i =0; i < st.Length; i++)
{
    array [i] = st[i];
}

Console.WriteLine(array[st.Length]);
// double number = Convert.ToSingle(st);


// Console.WriteLine(number);   // 23,56



// int result1 = Math.Sign(num1); //-1
// int i = 0;
// if (result1 == -1) {
//     num1 = num1*-1;
// }
// if (num1/10 >= 10)
// {
    
//    int k = num1/10;
//     while (k > 99)
//     {
//         k = k/10;
//         i++;
//     }
//     double num2 = Math.Pow(10, i);
    
//     double num3 = Math.Floor(num1/num2);
//     int num4 = Convert.ToInt32 (num3);
//     int ost100 = num4%10;
    
    
//     Console.WriteLine($"{num1} -> {ost100}");
// } 
// else 
// {
    // Console.WriteLine($"{num1} -> третий цифры нет ");
// }