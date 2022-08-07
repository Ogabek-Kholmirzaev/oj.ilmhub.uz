string[] str = Console.ReadLine()!.Split();

int s = int.Parse(str[0]);
int m = int.Parse(str[1]);

int res = s * 60 + m - 45;

if (res < 0)
    res += 24 * 60;

Console.WriteLine($"{res / 60} { res % 60}");