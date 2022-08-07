string n = Console.ReadLine()!;

for (int i = 0; i < 5 - n.Length; i++)
    Console.Write(0 + "!");

for(int i = 0; i < n.Length; i++)
{
    Console.Write(n[i]);

    if (i != n.Length - 1)
        Console.Write("!");
}