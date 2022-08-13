int Input()
{
    Console.WriteLine("Введите количество чисел от 1: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}
void Decision(int n)
{
    int count = 1;
    int x = 1;
    int z = 2;
    while (count < n)
    {
        x = x * z;
        z++;
        count++;
    }
    Console.Write("Произведение последовательных чисел от 1 до ");
    Console.Write(n);
    Console.Write(" == ");
    Console.Write(x);
}

int input = Input();
Decision(input);
