
Console.WriteLine("Введите в каком пространстве будем работать 2D и 3D (Введите числом) ");
int a = int.Parse(Console.ReadLine());
if (a == 2)
{
    Console.WriteLine("Вы используете двухмерное пространство ");
    TwoD();
    }
else if (a == 3)
{
    Console.WriteLine("Вы используете трехмерное пространство ");
    ThreeD();
}
else 
{
    Console.WriteLine("вы ввели некоректные данные ");
}

void TwoD()
{
    Console.WriteLine("Введите x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y2: ");
    double y2 = double.Parse(Console.ReadLine());
    double a = x2 - x1;
    double b = y2 - y1;
    double Sqr = Math.Pow(a,2);
    double Sqr2 = Math.Pow(b,2);
    double c = Sqr + Sqr2;
    Console.Write("Рстояние между точками == ");
    Console.WriteLine(Math.Sqrt(c));
}

void ThreeD()
{
    Console.WriteLine("Введите x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите z1: ");
    double z1= double.Parse(Console.ReadLine());
    Console.WriteLine("Введите z2: ");
    double z2 = double.Parse(Console.ReadLine());
    double a = x2 - x1;
    double b = y2 - y1;
    double e = z2 - z1;
    double Sqr = Math.Pow(a,2);
    double Sqr2 = Math.Pow(b,2);
    double Sqr3 = Math.Pow(e,2);
    double c = Sqr + Sqr2 + Sqr3;
    Console.Write("Рстояние между точками == ");
    Console.Write(Math.Sqrt(c));
}


