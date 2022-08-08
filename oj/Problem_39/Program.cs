int n = int.Parse(Console.ReadLine()!);

string[] nums = Console.ReadLine()!.Split();

int res = 0;

for (int i = 0; i < n; i++)
    res += (int)Math.Pow(double.Parse(nums[i]), 3);

Console.WriteLine(res);