int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

if (n == 1)
{
    m -= 500;
    Console.WriteLine("Americano");
}
else if (n == 2)
{
    m -= 400;
    Console.WriteLine("Caffe Latte");
}
else
{
    m -= 300;
    Console.WriteLine("Lemon Tea");
}

Console.WriteLine($"{m / 500} {(m % 500) / 100}");