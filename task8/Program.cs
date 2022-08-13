void Decision()
{
    int x = 123;
    int whole = x;
    int count = 0;
    
    while (whole != 0)
    {
        whole = whole / 10;
        count++;
    }
    
    Console.Write("В числе ");
    Console.Write(x);
    Console.Write(" количество цифр входящих в него ");
    Console.Write(count);

}

Decision();