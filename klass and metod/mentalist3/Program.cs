Person tom = new Person();          // вызов 1-ого конструктора без параметров
Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
Person sam = new Person("Sam", 20); // вызов 3-его конструктора с двумя параметрами
 
tom.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();          // Имя: Sam  Возраст: 25
 
class Person 
{
    public string name;
    public int age;
    public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор
    public Person(string n) { name = n; age = 18; }         // 2 конструктор
    public Person(string n, int a) { name = n; age = a; }   // 3 конструктор
 
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}