Console.WriteLine("Введите день недели: ");
int x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("Monday");
}
else if (x == 2)
{
    Console.WriteLine("Tuesday");
}
else if (x == 3)
{
    Console.WriteLine("Wednesday");
}
else if (x == 4)
{
    Console.WriteLine("Thursday");
}
else if (x == 5)
{
    Console.WriteLine("Friday");
}
else if (x == 6)
{
    Console.WriteLine("Saturday - weekend!");
}
else if (x == 7)
{
    Console.WriteLine("Sunday - weekend!");
}
else 
{
    Console.WriteLine("Вы ввели некоректное число. ");
}