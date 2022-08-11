Console.WriteLine("Введите число x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находиться в первой четверти системы координат ");
}
else if (x < 0 && y > 0)
{
   Console.WriteLine("Точка находиться во второй четверти системы координат "); 
}
else if (x < 0 && y < 0)
{
   Console.WriteLine("Точка находиться в третей четверти системы координат "); 
}
else if (x > 0 && y < 0)
{
   Console.WriteLine("Точка находиться в четвертой четверти системы координат "); 
}
else 
{
   Console.WriteLine("Точка лежит на оси координат ");
}