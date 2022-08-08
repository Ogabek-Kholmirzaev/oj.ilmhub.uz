string[] s1 = Console.ReadLine()!.Split();
string[] s2 = Console.ReadLine()!.Split();

int strike = 0;
int ball = 0;

for(int i = 0; i < 3; i++)
{
    if (s1[i] == s2[i])
    {
        strike++;
        continue;
    }
    else
    {
        bool check = false;
        for (int j = i + 1; j < 3; j++)
            if (s1[i] == s2[j] || s1[j] == s2[i])
            {
                check = true;
                break;
            }

        if (check) ball++;
    }
}

Console.WriteLine($"{strike}S{ball}B");