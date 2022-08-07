string[] str = Console.ReadLine()!.Split();

int a = Math.Max(int.Parse(str[0]), int.Parse(str[1]));
int b = Math.Min(int.Parse(str[0]), int.Parse(str[1]));

if (a == b * b)
    Console.WriteLine($"{b}*{b}={a}");
else
    Console.WriteLine("none");