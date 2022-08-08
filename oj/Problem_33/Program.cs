int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

if(n == m)
    Console.WriteLine("YORVORDIZ");
else
{
    if (n > m)
        Console.WriteLine("TEPAGA");
    else
        Console.WriteLine("PASTGA");

    m = int.Parse(Console.ReadLine()!);

    if (n == m)
        Console.WriteLine("YORVORDIZ");
    else if (n > m)
        Console.WriteLine("TEPAGA");
    else
        Console.WriteLine("PASTGA");
}