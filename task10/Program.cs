int Input()
{
    Console.WriteLine("Введите последовательность от 1 до n: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}
void Decision(int n)
{
    int y = 1;
    int count = 1;
    while (count <= n)
    {
        int x = y * y * y;
        y++;
        count++;
        if(x % 2 == 0)
        {
            Console.Write(x);
            Console.Write(" ");
        }
        
    }
}

int input = Input();
Console.Write("Кубы чисел заканчивающихся на четную цифру: ");
Decision(input);