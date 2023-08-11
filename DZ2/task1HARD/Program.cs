// задача 1 необязательная

// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 1,45 -> 1,5
// 1 -> нет
// 567,123 -> 57,123




Console.WriteLine("Введите число");

string st = Console.ReadLine();
string st1 = st;
var index = st.IndexOf(",");
if (index == 1)
{
st = st.Remove(2, 1);

Console.WriteLine($"{st1} -> {st}");

}
else if (st.Length <2)
{ Console.WriteLine($"{st1} -> нет");}


else
{
st = st.Remove(1, 1);

Console.WriteLine($"{st1} -> {st}");
}



