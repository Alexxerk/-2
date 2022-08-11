Console.WriteLine("Введите количество последовательных чисел от 1 которые нужно возвести в куб ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int x = 1;
int y = 0;

while(x <= n - 1)
{
y = x * x * x;
x = x + 1;
Console.Write(y);
Console.Write(", ");
}

y = n * n * n;
Console.Write(y);

