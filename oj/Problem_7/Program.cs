int n = int.Parse(Console.ReadLine()!);

string output1 = "Sun Mon Tue Wed Thu Fri Sat";
string? output2 = default;

for(int i = n; i <= n + 6; i++)
{
    int m = i > 31 ? i % 31 : i;
    
    output2 = String.Format(output2 + m + " ");
}

Console.WriteLine(output1 + "\n" + output2);