long n = int.Parse(Console.ReadLine()!);
long res = 1;
bool ans = false;

for(int i = 1; i < 20; i++)
{
    res *= i;
    if (n == res)
    {
        ans = true;
        break;
    }
    else if (res > n) break;
}

Console.WriteLine(ans);