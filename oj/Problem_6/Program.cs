int n = int.Parse(Console.ReadLine()!);

for(int i = 0; i < 4; i++)
{
    if(i == 0 || i == 3)
    {
        Console.WriteLine("" + n + n + n + n + n + n);
        continue;
    }

    Console.WriteLine($"{n}    {n}");
}