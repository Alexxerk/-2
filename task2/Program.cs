Console.WriteLine("Выясняем является ли 1 число квадратом 2 ");
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());

if (x == y * y)
{
    Console.Write("Число ");
    Console.Write(x);
    Console.Write(" является квадратом числа ");
    Console.Write(y);
}
else
{
    Console.Write("Число ");
    Console.Write(x);
    Console.Write(" не является квадратом числа ");
    Console.Write(y);
}


