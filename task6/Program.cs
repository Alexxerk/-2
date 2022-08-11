Console.WriteLine("Введите количество последовательных чисел от 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите шаг последовательности: ");
int z = int.Parse(Console.ReadLine());
int[] array = new int[a];
int x = 1;
int count = 1;
int sum = 0;

while(count < a)
{
    x = x + z;
    count++;
}

sum = ((1 + x) * a) / 2;



Console.Write("Сумма чисел данной арифметической последовательности ==  ");
Console.Write(sum);
