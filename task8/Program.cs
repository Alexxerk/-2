int Input()
{
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
return x;
}

int Size(int x)
{
    int whole = x;
    int count = 0;
    
    while (whole != 0)
    {
        whole = whole / 10;
        count++;
    }
    return count;
}

void Sum(int count, int x)
{
    int y = x % 10;
    int z = x / 10;
    int a = y;
    int count2 = 1;
    while (count2 < count)
    {
        y = z % 10;
        z = z / 10;
        a = a + y;
        count2++;
    }
    Console.Write("Сумма цифр входящих в число == ");
    Console.Write(a);
}

int input = Input();
int size = Size(input);

Sum(size, input);





